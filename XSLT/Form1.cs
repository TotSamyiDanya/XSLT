using System.Xml;
using System.Xml.Xsl;

namespace XSLT
{
    public partial class Form1 : Form
    {
        private readonly string _inputPath = "..\\..\\..\\Data1.xml";
        private readonly string _outputPath = "..\\..\\..\\Employees.xml";
        private readonly string _xsltPath = "..\\..\\..\\Transform.xslt";

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
    }
}