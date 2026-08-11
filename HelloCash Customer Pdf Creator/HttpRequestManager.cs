using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace HelloCash_Customer_Pdf_Creator
{
    public class HttpRequestManager
    {
        private Uri baseAddress = new Uri("https://api.hellocash.business/api/v1/");

        public async Task<Customer> GetData(string id)
        {
            using (var httpClient = new HttpClient { BaseAddress = baseAddress })
            {
                httpClient.DefaultRequestHeaders.TryAddWithoutValidation("authorization", $"Bearer {Values.API_Key}");

                using (var response = await httpClient.GetAsync($"users/{id}"))
                {
                    string jsonString = await response.Content.ReadAsStringAsync();
                    try
                    {
                        Customer c = JsonSerializer.Deserialize<Customer>(jsonString);
                        if (c.FirstName == null)
                        {
                            c.LastName = jsonString;
                        }

                        return c;
                    }
                    catch (Exception ex)
                    {
                        Customer c = new Customer()
                        {
                            FirstName = null,
                        };
                        return c;
                    }
                }
            }
        }
    }
}
