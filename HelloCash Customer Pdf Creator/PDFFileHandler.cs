using iText.Forms;
using iText.Kernel.Pdf;

namespace HelloCash_Customer_Pdf_Creator
{
    internal class PDFFileHandler
    {
        public void GeneratePDF(Customer c, string lang)
        {
            string templatePath = Path.Combine(Values.TemplatesPath, lang);

            if (AnyPdfExists(templatePath, out string outputFileTemplate))
            {
                using var reader = new PdfReader(outputFileTemplate);
                string fileName = $"{c.FirstName} {c.LastName} {DateTime.Now:yyyy-MM-dd}.pdf";
                
                //Check if filename already exists
                if (File.Exists(Path.Combine(Values.OutputPath, fileName)))
                {
                    fileName = $"{c.FirstName} {c.LastName} {DateTime.Now:yyyy-MM-dd-hh-mm-ss}.pdf";
                }

                using var writer = new PdfWriter(Path.Combine(Values.OutputPath, fileName));
                using var pdf = new PdfDocument(reader, writer);

                var form = PdfAcroForm.GetAcroForm(pdf, false);

                form.GetField("CustomerName")?.SetValue(c.FirstName + " " + c.LastName);
                form.GetField("CustomerAddress")?.SetValue(c.AddressStreet + " " + c.AddressNumber);
                form.GetField("CustomerPLZCity")?.SetValue(c.PostalCode + " " + c.City);
                form.GetField("CustomerPhone")?.SetValue(c.Phone);
                form.GetField("CustomerEmail")?.SetValue(c.Email);
                form.GetField("DateBox")?.SetValue(DateTime.Now.ToString("dd-MM-yyyy"));

                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo($"{Path.Combine(Values.OutputPath, fileName)}") { UseShellExecute = true });
            }
            else
            {
                MessageBox.Show("No PDF Template found for " + lang);
            }
        }

        bool AnyPdfExists(string dir, out string fullPath)
        {
            var files = Directory.GetFiles(dir, "*.pdf");
            fullPath = files.FirstOrDefault();
            return files.Length > 0;
        }
    }
}
