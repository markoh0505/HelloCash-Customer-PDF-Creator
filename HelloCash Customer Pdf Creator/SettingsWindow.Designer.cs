namespace HelloCash_Customer_Pdf_Creator
{
    partial class SettingsWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label2 = new Label();
            APIKeyBox = new TextBox();
            button1 = new Button();
            OutputFolderBox = new TextBox();
            toolTip1 = new ToolTip(components);
            button2 = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 69);
            label2.Name = "label2";
            label2.Size = new Size(128, 45);
            label2.TabIndex = 2;
            label2.Text = "API Key";
            // 
            // APIKeyBox
            // 
            APIKeyBox.Font = new Font("Segoe UI", 9F);
            APIKeyBox.Location = new Point(146, 82);
            APIKeyBox.Name = "APIKeyBox";
            APIKeyBox.Size = new Size(489, 31);
            APIKeyBox.TabIndex = 3;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.Font = new Font("Segoe UI", 14F);
            button1.Location = new Point(12, 6);
            button1.Name = "button1";
            button1.Size = new Size(302, 48);
            button1.TabIndex = 4;
            button1.Text = "Change Output Folder";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // OutputFolderBox
            // 
            OutputFolderBox.Font = new Font("Segoe UI", 9F);
            OutputFolderBox.Location = new Point(320, 19);
            OutputFolderBox.Name = "OutputFolderBox";
            OutputFolderBox.ReadOnly = true;
            OutputFolderBox.Size = new Size(315, 31);
            OutputFolderBox.TabIndex = 5;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F);
            button2.Location = new Point(296, 134);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 6;
            button2.Text = "Save";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // SettingsWindow
            // 
            AutoScaleDimensions = new SizeF(18F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(652, 180);
            Controls.Add(button2);
            Controls.Add(OutputFolderBox);
            Controls.Add(button1);
            Controls.Add(APIKeyBox);
            Controls.Add(label2);
            Font = new Font("Segoe UI", 16F);
            Margin = new Padding(5);
            Name = "SettingsWindow";
            Text = "SettingsWindow";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private TextBox APIKeyBox;
        private Button button1;
        private TextBox OutputFolderBox;
        private ToolTip toolTip1;
        private Button button2;
    }
}