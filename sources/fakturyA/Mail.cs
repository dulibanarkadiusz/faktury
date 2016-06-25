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
        private string receiverEmail;
        public Mail(string fileName) /// , Customer customer); 
        {
            this.fileName = fileName;
            this.receiverEmail = receiverEmail;
            Send();
        }

        private void Send()
        {
            Cursor.Current = Cursors.WaitCursor;

            // Command line argument must the the SMTP host.
            SmtpClient client = new SmtpClient();
            client.Port = 587;
            client.Host = "smtp.gmail.com";
            client.EnableSsl = true;
            client.Timeout = 10000;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Credentials = new System.Net.NetworkCredential("fakturka2016@gmail.com", "naszProjekt"); // set receiver


            MailMessage mm = new MailMessage();
            mm.From = new MailAddress("fakturka2016@gmail.com", "MojaFirma");
            mm.To.Add(new MailAddress("arkadiusz.duliban@gmail.com", "Arkadiusz Duliban"));
            mm.Subject = "Nowa faktura VAT ";
            mm.IsBodyHtml = true;
            mm.Body = "Dzień dobry,<br><br>W załączniku przesyłam Państwa fakturę VAT. Można ją otworzyć przy wykorzystaniu przeglądarki internetowej (Google Chrome, Mozilla Firefox) lub oprogramowania pozwalającego wyświetlać pliki PDF (np. Adobe Reader)<br><br>W razie pytań pozostajemy do Państwa dyspozycji.<br><br><br>Z poważaniem<br>"+MainProgram.Worker.Name;

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
