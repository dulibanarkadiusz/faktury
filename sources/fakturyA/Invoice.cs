using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;

namespace fakturyA
{
    public class Invoice
    {
        private int customerID;
        private string number;
        private DateTime invoiceDate;
        private DateTime paymentDate;
        private DateTime sellingDate;
        private decimal amountPaid;
        private decimal invoiceValue = 0;
        private decimal invoiceTotalNetto = 0;
        private string customerName;
        private string paymentMethod = "przelew";

        string[] paymentMethods = { "przelew", "gotówka", "karta płatnicza", "płatność online", "płatność ratalna" };

        public int Id_record { get; private set; }
        public string CusotmerName { get {return customerName;} set { customerName = value; } }
        public int EmployeeID { get; private set; }
        public string EmployeeName { get; private set; }
        public string CustomerNIP { get; private set; }
        public Customers Customer { get; set; }
        public List<ArticleOnInvoice> ArticlesOnInvoiceList { get; private set; }

        public int CustomerID
        {
            get { return customerID; }
            set
            {
                // sprawdź, czy klient istnieje
                customerID=value;
            }
        }

        public string Number {
            get { return number; }
            set
            {
                number = value;
            }
        }

        public DateTime InvoiceDate
        {
            get  { return invoiceDate; }
            set
            {
                DateTime tmp;
                if (DateTime.TryParse(value.ToString(), out tmp))
                    invoiceDate = value;
                else
                    throw new Exception("Cannot convert InvoiceDate");
            }
        }

        public DateTime PaymentDate 
        {
            get { return paymentDate; }
            set
            {
                DateTime tmp;
                if (DateTime.TryParse(value.ToString(), out tmp))
                    paymentDate = value;
                else
                    throw new Exception("Cannot convert PaymentDate");
            }
        }

        public DateTime SellingDate {
            get { return sellingDate; }
            set 
            {
                DateTime tmp;
                if (DateTime.TryParse(value.ToString(), out tmp))
                    sellingDate = value;
                else
                    throw new Exception("Cannot convert SellingDate");
            } 
        }

        public string PaymentMethod {
            get { return paymentMethod; }
            set
            {
                //if (Array.IndexOf(paymentMethods, value.ToString()) >= 0)
               // {
                    paymentMethod = value.ToString();
               // }
                //else
              //  {
                //    throw new Exception("Invalid payment method. ");
                //}
            }
        }
        public decimal AmountPaid
        {
            get { return amountPaid; }
            set
            {
                Decimal tmp;
                if (Decimal.TryParse(value.ToString(), out tmp))
                    amountPaid = value;
                else
                    throw new Exception("Cannot convert amountPaid");
            }
        }
        public decimal InvoiceValue {
            get 
            {
                return invoiceValue;
            }
            private set
            {
                invoiceValue = value;
            }
        }
        public decimal InvoiceTotalNetto
        {
            get
            {
                return invoiceTotalNetto;
            }
            private set
            {
                invoiceTotalNetto = value;
            }
        }


        // --- METODY --- 
        public void AddArticlePositionToInvoice(ArticleOnInvoice articleOnInvoice)
        {
            if (ArticlesOnInvoiceList.Count == 0)
                InvoiceValue = 0;

            ArticlesOnInvoiceList.Add(articleOnInvoice);
            InvoiceValue += articleOnInvoice.ValueBrutto;
            InvoiceTotalNetto += articleOnInvoice.ValueNetto;

            MainProgram.InvoiceEditor.WriteTotalInvoiceValue();
        }

        public ArticleOnInvoice FindAndGetArticleOnInvoice(string ArticleCode)
        {
            var findArticleOnInvoice = ( from ArticleOnInvoice articleOnInvoice in ArticlesOnInvoiceList
                                        where (articleOnInvoice.Article.Code == ArticleCode)
                                        select articleOnInvoice).FirstOrDefault();

            return findArticleOnInvoice;
        }



        // --- KONSTRUKTORY --- 
        public Invoice(string[] dataRow) // konstruktor dla już isntiejących faktur
        {
            try
            {
                ArticlesOnInvoiceList = new List<ArticleOnInvoice>();

                Id_record = Convert.ToInt16(dataRow[0]);
                Number = dataRow[1];
                EmployeeID = Convert.ToInt16(dataRow[2]);
                EmployeeName = dataRow[4];
                CusotmerName = dataRow[3];
                if (dataRow[5] != null)
                    CustomerNIP = dataRow[5];
                else 
                    CustomerNIP = "-";
                InvoiceValue = Convert.ToDecimal(dataRow[6]);
                InvoiceDate = Convert.ToDateTime(dataRow[8]);
                PaymentDate = Convert.ToDateTime(dataRow[9]);
                SellingDate = Convert.ToDateTime(dataRow[10]);
                CustomerID = Convert.ToInt16(dataRow[12]);
                Customer = new Customers(CustomerID);

                PaymentMethod = dataRow[11];
                AmountPaid = Convert.ToDecimal(dataRow[13]);

            }
            catch (Exception exc)
            {
                throw new Exception("One or more variables cannot be converted to correct format: "+exc.Message);
            }
        }

        public Invoice() // konstruktor dla nowych faktur 
        {
            CustomerID = -1;
            EmployeeID = MainProgram.Worker.ID;
            EmployeeName = MainProgram.Worker.Name;
            InvoiceDate = DateTime.Now;
            PaymentDate = DateTime.Now;
            SellingDate = DateTime.Now;
            ArticlesOnInvoiceList = new List<ArticleOnInvoice>();
        }




        // generatory zapytań MySQL
        public string GenerateUpdateQuery()
        {
            return String.Format("UPDATE faktura SET id_kontrahenta={0}, data_wystawienia='{1}', termin_platnosci='{2}', data_sprzedazy='{3}', forma_platnosci='{4}', zaplacona_kwota='{5}' WHERE numer='{6}'", CustomerID, InvoiceDate.ToString(), PaymentDate.ToString(), SellingDate.ToString(), Array.IndexOf(paymentMethods, PaymentMethod) + 1, AmountPaid.ToString(CultureInfo.InvariantCulture), Number);
        }

        public string GenerateInsertQuery()
        {
            return String.Format("INSERT INTO faktura SET numer='{0}', id_kontrahenta={1}, id_pracownika={2}, data_wystawienia='{3}', termin_platnosci='{4}', data_sprzedazy='{5}', forma_platnosci='{6}', zaplacona_kwota='{7}'", Number, CustomerID, MainProgram.Worker.ID, InvoiceDate, PaymentDate, SellingDate, Array.IndexOf(paymentMethods, PaymentMethod) + 1, AmountPaid);
        }

        public string GenerateDeleteQuery()
        {
            return String.Format("DELETE FROM faktura WHERE numer='{0}'", Number);
        }

        public string GenerateDeleteQueryForArticlesOnInvoice()
        {
            return String.Format("DELETE FROM pozycja_faktury WHERE nr_faktury='{0}'", Number);
        }
    }
}
