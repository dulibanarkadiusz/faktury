using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using iTextSharp.text; // biblioteka do PDFa
using iTextSharp.text.pdf;

namespace fakturyA
{
    class PDFgenerator
    {
        private Invoice invoice;
        public PDFgenerator(Invoice invoice)
        {
            this.invoice = invoice;
            Create();
        }

        private void Create()
        {
            MessageBox.Show("a");

            Document doc = new Document(iTextSharp.text.PageSize.A4);

            string pdfName = invoice.Number.Replace('/', '_') + ".pdf";
            try
            {
                PdfWriter wr = PdfWriter.GetInstance(doc, new FileStream(pdfName, FileMode.CreateNew));
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }

            doc.Open();
            doc.Add(new Paragraph("Faktura VAT nr "+invoice.Number));
            doc.Close();


            Mail mail = new Mail(pdfName);
        }
    }
}
