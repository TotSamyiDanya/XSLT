namespace XSLT
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TransformButton = new Button();
            EmployeeListBox = new ListBox();
            MonthDataGridView = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)MonthDataGridView).BeginInit();
            SuspendLayout();
            // 
            // TransformButton
            // 
            TransformButton.Location = new Point(12, 12);
            TransformButton.Name = "TransformButton";
            TransformButton.Size = new Size(160, 29);
            TransformButton.TabIndex = 0;
            TransformButton.Text = "Преобразовать";
            TransformButton.UseVisualStyleBackColor = true;
            TransformButton.Click += TransformButton_Click;
            // 
            // EmployeeListBox
            // 
            EmployeeListBox.FormattingEnabled = true;
            EmployeeListBox.Location = new Point(12, 86);
            EmployeeListBox.Name = "EmployeeListBox";
            EmployeeListBox.Size = new Size(266, 344);
            EmployeeListBox.TabIndex = 1;
            // 
            // MonthDataGridView
            // 
            MonthDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MonthDataGridView.Location = new Point(308, 86);
            MonthDataGridView.Name = "MonthDataGridView";
            MonthDataGridView.RowHeadersWidth = 51;
            MonthDataGridView.Size = new Size(326, 344);
            MonthDataGridView.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 53);
            label1.Name = "label1";
            label1.Size = new Size(216, 20);
            label1.TabIndex = 3;
            label1.Text = "Сумма выплат по сотруднику:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(308, 53);
            label2.Name = "label2";
            label2.Size = new Size(200, 20);
            label2.TabIndex = 4;
            label2.Text = "Сумма выплат по месяцам:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(655, 472);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(MonthDataGridView);
            Controls.Add(EmployeeListBox);
            Controls.Add(TransformButton);
            Name = "Form1";
            Text = "XSLT Преобразование";
            ((System.ComponentModel.ISupportInitialize)MonthDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button TransformButton;
        private ListBox EmployeeListBox;
        private DataGridView MonthDataGridView;
        private Label label1;
        private Label label2;
    }
}
