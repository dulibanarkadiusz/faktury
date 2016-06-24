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
        /* Ustawienia aplikacji */
        static MainProgram()
        {
            LoggedUser = null;
        }

        public static void LoggIn(string login)
        {
            LoggeUserID = 1;
            LoggedUser = login;

            // wyodrębnij: 
            NumberInfo = new CultureInfo("pl-PL", false).NumberFormat;

            NumberInfo.NumberDecimalSeparator = ".";
        }

        public static void LoggIn(Worker worker)
        {
            LoggeUserID = 1;
            LoggedUser = worker.LoginName;
            Worker = worker;

            // wyodrębnij: 
            NumberInfo = new CultureInfo("pl-PL", false).NumberFormat;

            NumberInfo.NumberDecimalSeparator = ".";
        }

        public static string LoggedUser { get; private set; }
        public static int LoggeUserID { get; private set; }
        public static Worker Worker { get; private set; }
        public static bool PermissionsLevel { get; private set; }
        public static Article AddedArticle { get; set; }
        public static NumberFormatInfo NumberInfo { get; private set; }

        /* Teksty i stałe */
        public const string CurrencySymbol = " zł";
        public const string ArticlesTablename = "artykul";
        public const string InvoicesTablename = "faktura";
        public const string CustomersTablename = "kontrahent";
        public const int DateLength = 10;
        public const string NameConfigFile = "config.xml";

        /* MySQL */
        public static MySqlConnection Connection { get; set; }
        public static string DatabaseName {get; set; }

        /* okienka aplikacji */
        public static FormInvoicesList InvoiceWindow { get; set; } 
        public static FormArticles ArticlesWindow { get; set; }
        public static FormInvoiceEditor InvoiceEditor { get; set; }
        public static FormCustomers CustomerWindow { get; set; }

        /* Listy */
        public static List<Invoice> InvoiceObjectsList { get; set; }
        public static List<Customers> CustomersList { get; set; }
        public static string EditedInvoiceNumber { get; set; }
    }
}
