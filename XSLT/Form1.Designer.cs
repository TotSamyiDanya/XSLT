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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TransformButton);
            Name = "Form1";
            Text = "XSLT Преобразование";
            ResumeLayout(false);
        }

        #endregion

        private Button TransformButton;
    }
}
