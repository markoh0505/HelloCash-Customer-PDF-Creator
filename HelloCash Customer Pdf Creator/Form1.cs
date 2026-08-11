using System.Reflection;
using System.Text.Json;

namespace HelloCash_Customer_Pdf_Creator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            SettingsManager.LoadSettings();

            UserIDBox.Text = Values.TestCustomerID;
            LanguagePickBox.DataSource = Values.Supportedlanguages;
            LanguagePickBox.SelectedItem = Values.Supportedlanguages[0];
            LanguagePickBox.DropDownStyle = ComboBoxStyle.DropDownList;

            if (!Directory.Exists(Values.OutputPath))
                Directory.CreateDirectory(Values.OutputPath);

            if (!Directory.Exists(Values.TemplatesPath))
            {
                Directory.CreateDirectory(Values.TemplatesPath);
            }

            foreach (string lang in Values.Supportedlanguages)
            {
                if (!Directory.Exists(Path.Combine(Values.TemplatesPath, lang)))
                {
                    Directory.CreateDirectory(Path.Combine(Values.TemplatesPath, lang));
                }
            }

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            HttpRequestManager manager = new HttpRequestManager();

            Customer c = await manager.GetData(UserIDBox.Text);

            if (c.FirstName == null)
            {
                MessageBox.Show(c.LastName, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            PDFFileHandler fileHandler = new PDFFileHandler();

            string language = "";

            if (LanguagePickBox.SelectedValue.ToString() == "Auto")
            {
                
                if (c.Lang == null)
                {
                    fileHandler.GeneratePDF(c, "DE");
                    return;
                }

                switch (c.Lang.ToLower())
                {
                    case "de":
                    case "deutsch":
                        language = "DE";
                        break;

                    case "fr":
                    case "französisch":
                        language = "FR";
                        break;

                    case "en":
                    case "english":
                        language = "EN";
                        break;

                    default:
                        language = "DE";
                        break;
                }

                fileHandler.GeneratePDF(c, language);
                return;
            }
            fileHandler.GeneratePDF(c, LanguagePickBox.SelectedValue.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var settings = new SettingsWindow();
            settings.Show();
        }
    }
}
