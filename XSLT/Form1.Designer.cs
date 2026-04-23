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
            EmployeeListBox.Size = new Size(444, 584);
            EmployeeListBox.TabIndex = 1;
            // 
            // MonthDataGridView
            // 
            MonthDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MonthDataGridView.Location = new Point(474, 86);
            MonthDataGridView.Name = "MonthDataGridView";
            MonthDataGridView.RowHeadersWidth = 51;
            MonthDataGridView.Size = new Size(551, 584);
            MonthDataGridView.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1037, 682);
            Controls.Add(MonthDataGridView);
            Controls.Add(EmployeeListBox);
            Controls.Add(TransformButton);
            Name = "Form1";
            Text = "XSLT Преобразование";
            ((System.ComponentModel.ISupportInitialize)MonthDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button TransformButton;
        private ListBox EmployeeListBox;
        private DataGridView MonthDataGridView;
    }
}
