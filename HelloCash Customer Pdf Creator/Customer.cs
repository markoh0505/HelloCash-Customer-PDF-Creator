using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HelloCash_Customer_Pdf_Creator
{
    public class Customer
    {
        [JsonPropertyName("user_firstname")]
        public string FirstName { get; set; }

        [JsonPropertyName("user_surname")]
        public string LastName { get; set; }

        [JsonPropertyName("user_salutation")]
        public string Title { get; set; }

        [JsonPropertyName("user_email")]
        public string Email { get; set; }

        [JsonPropertyName("user_street")]
        public string AddressStreet { get; set; }

        [JsonPropertyName("user_houseNumber")]
        public string AddressNumber { get; set; }

        [JsonPropertyName("user_city")]
        public string City { get; set; }

        [JsonPropertyName("user_postalCode")]
        public string PostalCode { get; set; }

        [JsonPropertyName("user_phoneNumber")]
        public string Phone { get; set; }

        [JsonPropertyName("user_custom_fields")]
        public JsonElement? CustomFields { get; set; }

        public string Lang => CustomFields?.GetProperty("Sprache").GetString();
    }
}
