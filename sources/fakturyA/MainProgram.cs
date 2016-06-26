using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Globalization;

namespace fakturyA
{
    static class MainProgram
    {
        public static Worker Worker { get; private set; }
        public static OurCompany OurCompany { get; private set; }
        static MainProgram()
        {
            OurCompany = new OurCompany();
        }

        public static void LoggIn(Worker worker)
        {
            Worker = worker;
        }


        /* Teksty i stałe */
        public const string CurrencySymbol = " zł";
        public const string ArticlesTablename = "artykul";
        public const string InvoicesTablename = "faktura";
        public const string CustomersTablename = "kontrahent";
        public const int DateLength = 10; // długość daty 
        public const string NameConfigFile = "config.xml";

        /* MySQL */
        public static MySqlConnection Connection { get; set; }
        public static string DatabaseName {get; set; }

        /* okienka aplikacji */
        public static FormInvoicesList InvoiceWindow { get; set; } 
        public static FormArticles ArticlesWindow { get; set; }
        public static FormInvoiceEditor InvoiceEditor { get; set; }
        public static FormCustomers CustomerWindow { get; set; }
        public static FormOurCompanyDataEditor OurCompanyWindow { get; set; }

        /* Listy */
        public static List<Invoice> InvoiceObjectsList { get; set; }
        public static List<Customers> CustomersList { get; set; }
        public static string EditedInvoiceNumber { get; set; }
    }
}
