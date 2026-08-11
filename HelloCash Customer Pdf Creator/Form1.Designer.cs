namespace HelloCash_Customer_Pdf_Creator
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
            GeneratePDFBtn = new Button();
            UserIDBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            LanguagePickBox = new ComboBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // GeneratePDFBtn
            // 
            GeneratePDFBtn.Location = new Point(22, 128);
            GeneratePDFBtn.Margin = new Padding(5);
            GeneratePDFBtn.Name = "GeneratePDFBtn";
            GeneratePDFBtn.Size = new Size(613, 61);
            GeneratePDFBtn.TabIndex = 0;
            GeneratePDFBtn.Text = "Generate PDF";
            GeneratePDFBtn.UseVisualStyleBackColor = true;
            GeneratePDFBtn.Click += button1_Click;
            // 
            // UserIDBox
            // 
            UserIDBox.Location = new Point(153, 61);
            UserIDBox.Margin = new Padding(5);
            UserIDBox.Name = "UserIDBox";
            UserIDBox.Size = new Size(341, 50);
            UserIDBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 261);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 45);
            label1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 67);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(131, 45);
            label2.TabIndex = 3;
            label2.Text = "User ID:";
            // 
            // LanguagePickBox
            // 
            LanguagePickBox.FormattingEnabled = true;
            LanguagePickBox.Items.AddRange(new object[] { "Auto", "DE", "FR", "EN" });
            LanguagePickBox.Location = new Point(502, 59);
            LanguagePickBox.MaxDropDownItems = 3;
            LanguagePickBox.Name = "LanguagePickBox";
            LanguagePickBox.Size = new Size(133, 53);
            LanguagePickBox.TabIndex = 4;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F);
            button2.Location = new Point(548, 12);
            button2.Name = "button2";
            button2.Size = new Size(88, 35);
            button2.TabIndex = 5;
            button2.Text = "Settings";
            button2.TextAlign = ContentAlignment.TopCenter;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(18F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(649, 213);
            Controls.Add(button2);
            Controls.Add(LanguagePickBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(UserIDBox);
            Controls.Add(GeneratePDFBtn);
            Font = new Font("Segoe UI", 16F);
            Margin = new Padding(5);
            Name = "Form1";
            Text = "HelloCash Customer PDF Creator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button GeneratePDFBtn;
        private TextBox UserIDBox;
        private Label label1;
        private Label label2;
        private ComboBox LanguagePickBox;
        private Button button2;
    }
}
