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
        private string pdfName; 
        private const string FONT = "c:/windows/fonts/arial.ttf";
        private BaseFont bf = BaseFont.CreateFont(FONT, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
        private const int SMALL_FONT_SIZE = 8;

        private decimal valueNetto = 0;
        private decimal valueBrutto = 0;
        private decimal valueVAT = 0;

        private Document doc;
        private decimal[] vatVALUE = new decimal[100];

        public PDFgenerator(Invoice invoice)
        {
            this.invoice = invoice;
            Create();
        }

        private void CheckIfFileExsist()
        {
            pdfName = invoice.Number.Replace('/', '_') + ".pdf";
            if (File.Exists(pdfName))
            {
                var result = MessageBox.Show("Plik tej faktury już istnieje. Czy chcesz kontynuować, nadpisując wcześniej wygenerowany dokument?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        File.Delete(pdfName);
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                    }

                }
            }
        }

        private void WriteHeader()
        {
            PdfPTable table = new PdfPTable(2);

            float[] widths = new float[] { 60f, 40f };
            table.SetWidths(widths);
            table.DefaultCell.Border = Rectangle.NO_BORDER;
            table.WidthPercentage = 90f;
            table.SpacingBefore = 30f;

            Paragraph paragraph = new Paragraph("Faktura VAT nr " + invoice.Number, new Font(bf, 16));
            table.AddCell(paragraph);

            PdfPTable table2 = new PdfPTable(2);
            table2.DefaultCell.Border = Rectangle.NO_BORDER;
            table2.WidthPercentage = 40f;
            paragraph = new Paragraph("Data wystawienia:", new Font(bf, 9));
            table2.AddCell(paragraph); //name
            paragraph = new Paragraph((invoice.InvoiceDate).ToString().Remove(invoice.InvoiceDate.ToString().IndexOf(" ")), new Font(bf, 9));
            table2.AddCell(paragraph); // value 
            paragraph = new Paragraph("Data sprzedaży:", new Font(bf, 9));
            table2.AddCell(paragraph); //name
            paragraph = new Paragraph((invoice.SellingDate).ToString().Remove(invoice.SellingDate.ToString().IndexOf(" ")), new Font(bf, 9));
            table2.AddCell(paragraph); // value 
            table.AddCell(table2);
            ///
            doc.Add(table);
        }

        private void WriteSellerAndConsumerData()
        {
            PdfPTable table = new PdfPTable(2);
            float[] widths = new float[] { 65f, 35f };
            table.SetWidths(widths);
            table.DefaultCell.Border = Rectangle.NO_BORDER;
            table.WidthPercentage = 90f;
            table.SpacingBefore = 10f;

            // sprzedawca
            string regonString = (MainProgram.OurCompany.Regon.Length > 0) ? "\nREGON: " + MainProgram.OurCompany.Regon : "";
            Paragraph paragraph = new Paragraph(String.Format("Sprzedający:\n\n{0}\n{1}\n{2}\nNIP: {3}{4}", MainProgram.OurCompany.CompanyName, MainProgram.OurCompany.PlaceAddres, MainProgram.OurCompany.Code + ' ' +MainProgram.OurCompany.City, MainProgram.OurCompany.NIP, regonString), new Font(bf, 10));
            table.AddCell(paragraph);

            // kupujący
            paragraph = new Paragraph(String.Format("Nabywca:\n\n{0}\n{1}\n{2}\n{3} {4}\n", invoice.Customer.CompanyName, invoice.Customer.CustomerName, invoice.Customer.Address, invoice.Customer.Code, invoice.Customer.City), new Font(bf, 10));
            table.AddCell(paragraph);

            doc.Add(table);
        }

        private void WriteArticlesList()
        {
            PdfPTable table = new PdfPTable(11);
            table.SpacingBefore = 40f;
            table.WidthPercentage = 100f;
            float[] widths = new float[] { 3f, 23f, 6f, 5f, 6f, 7f, 4f, 9f, 9f, 9f, 9f };
            table.SetWidths(widths);
            string[] descs = new string[] { "Lp.", "Nazwa", "j.m.", "ilość", "rabat [%]", "cena netto", "VAT [%]", "cena brutto [zł]", "kwota VAT [zł]", "wartość netto [zł]", "wartość brutto [zł]" };

            foreach (String desc in descs)
            {
                Paragraph paragraph = new Paragraph(desc, new Font(bf, SMALL_FONT_SIZE));
                table.AddCell(paragraph);
            }

            MainProgram.InvoiceEditor = new FormInvoiceEditor(invoice);
            if (invoice.InvoiceTotalNetto < 0.01m)
            {
                DatabaseMySQL.LoadPositionsOnInvoice(invoice);
            }

            int i = 0;
            foreach (ArticleOnInvoice articleInvoice in invoice.ArticlesOnInvoiceList)
            {
                table.AddCell(new Paragraph(i + 1 + ".", new Font(bf, SMALL_FONT_SIZE)));
                table.AddCell(new Paragraph(invoice.ArticlesOnInvoiceList[i].Article.Name, new Font(bf, SMALL_FONT_SIZE)));
                table.AddCell(new Paragraph(invoice.ArticlesOnInvoiceList[i].Article.UnitMeasure, new Font(bf, SMALL_FONT_SIZE)));
                table.AddCell(new Paragraph("" + invoice.ArticlesOnInvoiceList[i].Amount, new Font(bf, SMALL_FONT_SIZE)));
                table.AddCell(new Paragraph("" + invoice.ArticlesOnInvoiceList[i].Discount, new Font(bf, SMALL_FONT_SIZE)));
                table.AddCell(new Paragraph("" + invoice.ArticlesOnInvoiceList[i].Article.PriceNetto, new Font(bf, SMALL_FONT_SIZE)));
                table.AddCell(new Paragraph("" + invoice.ArticlesOnInvoiceList[i].Article.VATvalue, new Font(bf, SMALL_FONT_SIZE)));
                table.AddCell(new Paragraph("" + invoice.ArticlesOnInvoiceList[i].Article.PriceBrutto, new Font(bf, SMALL_FONT_SIZE)));
                table.AddCell(new Paragraph("" + (invoice.ArticlesOnInvoiceList[i].ValueBrutto - invoice.ArticlesOnInvoiceList[i].ValueNetto), new Font(bf, SMALL_FONT_SIZE)));
                table.AddCell(new Paragraph("" + invoice.ArticlesOnInvoiceList[i].ValueNetto, new Font(bf, SMALL_FONT_SIZE)));
                table.AddCell(new Paragraph("" + invoice.ArticlesOnInvoiceList[i].ValueBrutto, new Font(bf, SMALL_FONT_SIZE)));

                vatVALUE[Convert.ToInt16(invoice.ArticlesOnInvoiceList[i].Article.VATvalue)] += invoice.ArticlesOnInvoiceList[i].ValueNetto;
                i++;
            }
            doc.Add(table);
        }

        private void WritePaymentDetails_And_VATtarget()
        {
            PdfPTable table2 = new PdfPTable(3);
            float[] widths = new float[] { 30f, 60f, 10f };
            table2.SetWidths(widths);
            table2.DefaultCell.Border = Rectangle.NO_BORDER;
            table2.AddCell(new Paragraph("Forma płatności: \t", new Font(bf, SMALL_FONT_SIZE)));
            table2.AddCell(new Paragraph("" + invoice.PaymentMethod, new Font(bf, SMALL_FONT_SIZE)));
            table2.AddCell("");
            table2.AddCell(new Paragraph("Numer konta: \t", new Font(bf, SMALL_FONT_SIZE)));
            table2.AddCell(new Paragraph(MainProgram.OurCompany.BankAccount1, new Font(bf, SMALL_FONT_SIZE)));
            table2.AddCell("");
            table2.AddCell(new Paragraph("Termin płatności: \t", new Font(bf, SMALL_FONT_SIZE)));
            table2.AddCell(new Paragraph("" + (invoice.PaymentDate).ToString().Remove(invoice.PaymentDate.ToString().IndexOf(" ")), new Font(bf, SMALL_FONT_SIZE)));
            table2.AddCell("");
            table2.AddCell(new Paragraph("Do zapłaty: \t", new Font(bf, SMALL_FONT_SIZE)));
            table2.AddCell(new Paragraph(invoice.InvoiceValue + " zł", new Font(bf, SMALL_FONT_SIZE)));
            table2.AddCell("");
            table2.AddCell(new Paragraph("Słownie: \t", new Font(bf, SMALL_FONT_SIZE)));
            table2.AddCell(new Paragraph(DecimalToWords.Convert(invoice.InvoiceValue), new Font(bf, SMALL_FONT_SIZE)));
            table2.AddCell("");
            table2.AddCell(new Paragraph("Zapłacono: \t", new Font(bf, SMALL_FONT_SIZE)));
            table2.AddCell(new Paragraph(invoice.AmountPaid + " zł", new Font(bf, SMALL_FONT_SIZE)));
            table2.AddCell("");

            // ---- podsumowanie stawek VAT na fakturze
            PdfPTable table = new PdfPTable(2);
            table.SpacingBefore = 15f;
            table.WidthPercentage = 100f;
            widths = new float[] { 50, 50 };
            table.SetWidths(widths);
            //table.SpacingBefore = -50;
            table.DefaultCell.Border = Rectangle.NO_BORDER;
            table.AddCell(table2);

            table2 = new PdfPTable(4);
            table2.SpacingBefore = 40f;
            string[] descs = new string[] { "Wartość netto [zł]", "VAT [%]", "Kwota VAT [zł]", "Wartość brutto [zł]" };
            foreach (String desc in descs)
            {
                table2.AddCell(new Paragraph(desc, new Font(bf, SMALL_FONT_SIZE)));
            }

            int j = 0;
            foreach (decimal vatTax in vatVALUE)
            {
                if (vatTax > 0)
                {
                    table2.AddCell(new Paragraph("" + vatTax, new Font(bf, SMALL_FONT_SIZE)));
                    table2.AddCell(new Paragraph(j + "", new Font(bf, SMALL_FONT_SIZE)));
                    table2.AddCell(new Paragraph(Math.Round(vatTax * j * 0.01m, 2) + "", new Font(bf, SMALL_FONT_SIZE)));
                    table2.AddCell(new Paragraph(Math.Round(vatTax * j * 0.01m + vatTax, 2) + "", new Font(bf, SMALL_FONT_SIZE)));

                    valueNetto += vatTax;
                    valueBrutto += Math.Round(vatTax * j * 0.01m + vatTax, 2);
                    valueVAT += Math.Round(vatTax * j * 0.01m, 2);
                }

                j++;
            }

            PdfPCell cell = new PdfPCell(table2);
            cell.Border = Rectangle.NO_BORDER;
            cell.VerticalAlignment = Element.ALIGN_RIGHT;
            table.AddCell(cell);
            table.AddCell("");
            table2 = new PdfPTable(4);
            table2.SpacingBefore = 5f;
            table2.AddCell(new Paragraph("" + valueNetto, new Font(bf, SMALL_FONT_SIZE)));
            table2.AddCell(new Paragraph("-", new Font(bf, SMALL_FONT_SIZE)));
            table2.AddCell(new Paragraph("" + valueVAT, new Font(bf, SMALL_FONT_SIZE)));
            table2.AddCell(new Paragraph("" + valueBrutto, new Font(bf, SMALL_FONT_SIZE)));

            cell = new PdfPCell(table2);
            cell.Border = Rectangle.NO_BORDER;
            cell.VerticalAlignment = Element.ALIGN_RIGHT;
            table.AddCell(cell);


            //table.HorizontalAlignment = Element.ALIGN_RIGHT;

            doc.Add(table);
        }

        private void WriteSignatures()
        {
            PdfPTable table = new PdfPTable(2);
            table.SpacingBefore = 70f;
            table.WidthPercentage = 90f;
            table.HorizontalAlignment = Element.ALIGN_CENTER;
            table.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;
            table.DefaultCell.Border = Rectangle.NO_BORDER;
            float[] widths = new float[] { 45, 45 };
            string dotted = ".";
            for (int k = 2; k < 75; k++)
            {
                dotted += ".";
            }

            table.AddCell("");
            table.AddCell(new Paragraph(invoice.EmployeeName, new Font(bf, 12)));
            table.AddCell(new Paragraph("" + dotted, new Font(bf, SMALL_FONT_SIZE)));
            table.AddCell(new Paragraph("" + dotted, new Font(bf, SMALL_FONT_SIZE)));
            table.AddCell(new Paragraph("osoba upoważniona do odbioru", new Font(bf, SMALL_FONT_SIZE)));
            table.AddCell(new Paragraph("osoba upoważniona do wystawienia", new Font(bf, SMALL_FONT_SIZE)));

            doc.Add(table);
        }


        private void Create()
        {
            doc = new Document(iTextSharp.text.PageSize.A4);
            CheckIfFileExsist();

            try
            {
                PdfWriter wr = PdfWriter.GetInstance(doc, new FileStream(pdfName, FileMode.CreateNew));
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }

            doc.Open();

            List<String> ContentList = new List<String>();
            decimal[] vatVALUE = new decimal[100];


            WriteHeader();

            // pozioma linia 
            Paragraph horizontalLine = new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0.0F, 100.0F, BaseColor.BLACK, Element.ALIGN_LEFT, 1)));
            doc.Add(horizontalLine);

            WriteSellerAndConsumerData();

            WriteArticlesList();

            WritePaymentDetails_And_VATtarget();

            WriteSignatures();


            doc.Close();
            Mail mail = new Mail(pdfName, invoice);
        }
    }
}
