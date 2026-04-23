using System.Globalization;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Xsl;

namespace XSLT
{
    public partial class Form1 : Form
    {
        private readonly string _inputPath = "..\\..\\..\\Data\\Data1.xml";
        private readonly string _outputPath = "..\\..\\..\\Data\\Employees.xml";
        private readonly string _xsltPath = "..\\..\\..\\Data\\Transform.xslt";

        public Form1()
        {
            InitializeComponent();
        }

        public void TransformXML(string inputPath, string outputPath, string xsltPath)
        {
            var xlst = new XslCompiledTransform();
            xlst.Load(xsltPath);
            xlst.Transform(inputPath, outputPath);
        }

        public void AddSumToEmployees(string path)
        {
            var doc = new XmlDocument();
            doc.Load(path);

            var namespaceManager = new XmlNamespaceManager(doc.NameTable);
            var employeeNodeList = doc.SelectNodes("//Employee");

            if (employeeNodeList == null)
                return;

            foreach (XmlNode employee in employeeNodeList)
            {
                var employeeAttributes = employee.Attributes;

                if (employeeAttributes == null)
                    return;

                double sum = 0;
                var salaryNodeList = employee.SelectNodes("salary");

                if (salaryNodeList == null)
                    return;

                foreach (XmlNode salary in salaryNodeList)
                {
                    var amountAttribute = salary.Attributes?["amount"];

                    if (amountAttribute == null)
                        return;

                    if (double.TryParse(amountAttribute.Value.Replace(',', '.'), out double amount))
                        sum += amount;
                }

                var totalAmountAttribute = doc.CreateAttribute("totalAmount");
                totalAmountAttribute.Value = sum.ToString();

                employeeAttributes.Append(totalAmountAttribute);
            }

            doc.Save(path);
        }

        public void AddTotalAmountToPay(string path)
        {
            var doc = new XmlDocument();
            doc.Load(path);

            var documentElement = doc.DocumentElement;

            if (documentElement == null)
                return;

            double totalAmount = 0;

            var itemNodeList = doc.SelectNodes("//item");

            if (itemNodeList == null)
                return;

            foreach (XmlNode item in itemNodeList)
            {
                var amountAttribute = item.Attributes?["amount"];

                if (amountAttribute == null)
                    return;

                if (double.TryParse(amountAttribute.Value.Replace(',', '.'), out double amount))
                    totalAmount += amount;

                var totalAmountAttribute = doc.CreateAttribute("totalAmount");
                totalAmountAttribute.Value = totalAmount.ToString();

                documentElement.Attributes.Append(totalAmountAttribute);
                doc.Save(path);
            }
        }

        public void ShowData()
        {
            EmployeeListBox.Items.Clear();
            MonthDataGridView.Rows.Clear();

            var doc = XDocument.Load(_outputPath);
            var employees = doc.Descendants("Employee");

            foreach (var employee in employees)
            {
                var name = employee.Attribute("name")?.Value ?? "";
                var surname = employee.Attribute("surname")?.Value ?? "";
                var sumSalary = employee.Attribute("totalAmount")?.Value ?? "0";

                string displayText = $"{name} {surname} - {sumSalary}";
                EmployeeListBox.Items.Add(displayText);
            }

            var monthsSum = new Dictionary<string, double>();

            foreach (var employee in employees)
            {
                var salaryNodeList = employee.Elements("salary");
                if (salaryNodeList == null)
                    return;

                foreach (var salary in salaryNodeList)
                {
                    var mountNode = salary.Attribute("mount");
                    if (mountNode == null) 
                        return;

                    string mount = mountNode.Value;
                    double amount = 0;

                    if (double.TryParse(salary.Attribute("amount")?.Value.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out double val))
                        amount = val;

                    if (monthsSum.ContainsKey(mount))
                        monthsSum[mount] += amount;
                    else
                        monthsSum[mount] = amount;
                }
            }

            MonthDataGridView.Columns.Clear();
            MonthDataGridView.Columns.Add("Month", "Месяц");
            MonthDataGridView.Columns.Add("Sum", "Сумма");

            foreach (var kvp in monthsSum)
            {
                MonthDataGridView.Rows.Add(kvp.Key, kvp.Value);
            }
        }

        private void TransformButton_Click(object sender, EventArgs e)
        {
            TransformXML(_inputPath, _outputPath, _xsltPath);
            AddSumToEmployees(_outputPath);
            AddTotalAmountToPay(_inputPath);
            ShowData();
        }
    }
}