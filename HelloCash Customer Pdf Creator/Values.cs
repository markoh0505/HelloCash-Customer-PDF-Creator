using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCash_Customer_Pdf_Creator
{
    public static class Values
    {
        public static readonly string Root = AppDomain.CurrentDomain.BaseDirectory;
        public static string API_Key = "";

        public const string TestCustomerID = "";
        public static string OutputPath = Path.Combine(Root, "Output");
        public static readonly string TemplatesPath = Path.Combine(Root, "Templates");
        public static readonly string[] Supportedlanguages = ["Auto", "DE", "FR", "EN"];
    }
}
