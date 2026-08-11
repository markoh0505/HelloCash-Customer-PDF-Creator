using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static HelloCash_Customer_Pdf_Creator.SettingsManager;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HelloCash_Customer_Pdf_Creator
{
    public partial class SettingsWindow : Form
    {
        public SettingsWindow()
        {
            InitializeComponent();

            OutputFolderBox.Text = Values.OutputPath;
            APIKeyBox.Text = Values.API_Key;
            toolTip1.SetToolTip(OutputFolderBox, OutputFolderBox.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using var dialog = new FolderBrowserDialog();
            dialog.Description = "Select a folder";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string selectedPath = dialog.SelectedPath;
                OutputFolderBox.Text = selectedPath;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Settings newSettings = new Settings()
            {
                OutputPath = OutputFolderBox.Text,
                APIKey = APIKeyBox.Text
            };
            SettingsManager.SaveSettings(newSettings);
            MessageBox.Show("Settings Saved!");
            this.Close();
        }
    }
}
