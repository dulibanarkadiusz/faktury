using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Windows.Forms;

namespace fakturyA
{
    class Mail
    {
        private string fileName;
        private Invoice invoice;
        public Mail(string fileName, Invoice invoice)
        {
            this.fileName = fileName;
            this.invoice = invoice;
            Send();
        }

        private void Send()
        {
            Cursor.Current = Cursors.WaitCursor;

            SmtpClient client = new SmtpClient();
            client.Port = 587;
            client.Host = "smtp.gmail.com";
            client.EnableSsl = true;
            client.Timeout = 10000;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Credentials = new System.Net.NetworkCredential("fakturka2016@gmail.com", "naszProjekt"); // set receiver

            MailMessage mm = new MailMessage();
            mm.From = new MailAddress("fakturka2016@gmail.com", MainProgram.OurCompany.CompanyName);
            string name = invoice.Customer.CompanyName == null ? invoice.Customer.CustomerName : invoice.Customer.CompanyName;
            mm.To.Add(new MailAddress(invoice.Customer.Email, invoice.Customer.CompanyName));
            mm.Subject = "Faktura VAT nr "+invoice.Number;
            mm.IsBodyHtml = true;
            mm.Body = String.Format("Dzień dobry,<br><br>W załączniku przesyłam Państwa fakturę VAT nr {0} z dnia {1}. Faktura opiewa na kwotę {2} złotych, ", invoice.Number, invoice.InvoiceDate, invoice.InvoiceValue);
            mm.Body += String.Format("która powinna zostać uregulawana najpóźniej do {0}.<br><br>Szczegóły dotyczące faktury znajdą Państwo w pliku faktury.<br><br>", invoice.PaymentDate);
            mm.Body += String.Format("W imieniu firmy dziękuję za zakupy i zapraszam do dalszej współpracy.<br><br><br><b>{0}</b><i><br><br>{1}<br>{2}<br>{3}</i>", invoice.EmployeeName, MainProgram.OurCompany.CompanyName, MainProgram.OurCompany.PlaceAddres, MainProgram.OurCompany.Code + ' ' + MainProgram.OurCompany.City);


            System.Net.Mail.Attachment attachment;
            attachment = new System.Net.Mail.Attachment(fileName);
            mm.Attachments.Add(attachment);

            mm.BodyEncoding = UTF8Encoding.UTF8;
            mm.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;

            client.Send(mm);
            MessageBox.Show("Email wysłany!");
            Cursor.Current = Cursors.Default;
        }
    }
}
