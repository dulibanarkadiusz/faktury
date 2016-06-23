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
        private const string FONT = "c:/windows/fonts/arial.ttf";
        private const int SMALL_FONT_SIZE = 8;
        public PDFgenerator(Invoice invoice)
        {
            this.invoice = invoice;
            Create();
        }

        private void Create()
        {
            Document doc = new Document(iTextSharp.text.PageSize.A4);

            string pdfName = invoice.Number.Replace('/', '_') + ".pdf";
            if (File.Exists(pdfName))
            {
                var result = MessageBox.Show("Plik tej faktury już istnieje. Czy chcesz kontynuować, nadpisując wcześniej wygenerowany dokument?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        File.Delete(pdfName);
                    }
                    catch(Exception e)
                    {
                        MessageBox.Show(e.Message);
                    }
                    
                }
            }

            try
            {
                PdfWriter wr = PdfWriter.GetInstance(doc, new FileStream(pdfName, FileMode.CreateNew));
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }

            BaseFont bf = BaseFont.CreateFont(FONT, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
            BaseFont arialBold = BaseFont.CreateFont(FONT, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
            doc.Open();

            List<String> ContentList = new List<String>();
            Paragraph paragraph;
            string content;
            decimal[] vatVALUE = new decimal[100];


            // --- tabela na nagłówek
            PdfPTable table = new PdfPTable(2);

            float[] widths = new float[] { 60f, 40f };
            table.SetWidths(widths);
            table.DefaultCell.Border = Rectangle.NO_BORDER;
            table.WidthPercentage = 90f;
            table.SpacingBefore = 30f;


            paragraph = new Paragraph("Faktura VAT nr " + invoice.Number, new Font(bf, 16));
            table.AddCell(paragraph);

            ///
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


            // pozioma linia 
            Paragraph horizontalLine = new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0.0F, 100.0F, BaseColor.BLACK, Element.ALIGN_LEFT, 1)));
            doc.Add(horizontalLine);



            // --- tabela na dane kontrahenta i naszej firmy --- 
            table = new PdfPTable(2);
            widths = new float[] { 65f, 35f };
            table.SetWidths(widths);
            table.DefaultCell.Border = Rectangle.NO_BORDER;
            table.WidthPercentage = 90f;
            table.SpacingBefore = 10f;

            // sprzedawca
            content = String.Format("Sprzedający:\n\n{0}\n{1}\n{2}\nNIP: {3}", "Fakturzyści sp. z o.o.", "Kaszubska 28", "44-100 Gliwice", "8392102392");
            paragraph = new Paragraph(content, new Font(bf, 10));
            table.AddCell(paragraph);

            // kupujący
            content = String.Format("Nabywca:\n\n{0}\n{1}\n{2}\n", invoice.CusotmerName, "ul. Jakaś 90/8", "00-000 Warszawa");
            paragraph = new Paragraph(content, new Font(bf, 10));
            table.AddCell (paragraph);

            doc.Add(table);
            // ---- KONIEC TABELI --- 


            // --- tabela na artykuły --- 
            table = new PdfPTable(11);
            table.SpacingBefore = 20f;
            table.WidthPercentage = 100f;
            widths = new float[] { 3f, 23f, 4f, 3f, 3f, 10f, 4f, 10f, 10f, 10f, 10f };
            table.SetWidths(widths);
            string[] descs = new string[] { "Lp.", "Nazwa", "j.m.", "ilość", "rabat [%]", "cena netto", "VAT [%]", "cena brutto [zł]", "kwota VAT [zł]", "wartość netto [zł]", "wartość brutto [zł]"};
            
            foreach (String desc in descs)
            {
                paragraph = new Paragraph(desc, new Font(bf, SMALL_FONT_SIZE));
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
                table.AddCell(new Paragraph(i+1+".", new Font(bf, SMALL_FONT_SIZE)));
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

                //MessageBox.Show(Convert.ToInt16(invoice.ArticlesOnInvoiceList[i].Article.VATvalue)+"");
                //vatVALUE[Convert.ToInt16(invoice.ArticlesOnInvoiceList[i].Article.VATvalue)/100] = 0;
                vatVALUE[Convert.ToInt16(invoice.ArticlesOnInvoiceList[i].Article.VATvalue)] += invoice.ArticlesOnInvoiceList[i].ValueNetto;
                i++;
            }
            doc.Add(table);



            // ---- podsumowanie stawek VAT na fakturze
            table = new PdfPTable(2);
            widths = new float[] { 40, 50};
            table.SetWidths(widths);
            table.DefaultCell.Border = Rectangle.NO_BORDER;
            table.AddCell("");

            table2 = new PdfPTable(4);
            table2.SpacingBefore = 20f;


            descs = new string[] { "Wartość netto [zł]", "VAT [%]", "Kwota VAT [zł]", "Wartość brutto [zł]" };
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
                    table2.AddCell(new Paragraph(j + "",new Font(bf, SMALL_FONT_SIZE)));
                    table2.AddCell(new Paragraph(Math.Round(vatTax * j * 0.01m, 2) + "", new Font(bf, SMALL_FONT_SIZE)));
                    table2.AddCell(new Paragraph(Math.Round(vatTax * j * 0.01m + vatTax, 2) + "", new Font(bf, SMALL_FONT_SIZE)));
                }

                j++;
            }
            table.AddCell(table2);
            table.HorizontalAlignment = Element.ALIGN_RIGHT;

            doc.Add(table);
            ////////


            // ---- informacje tabela ----
            table = new PdfPTable(3);
            widths = new float[] { 20f, 30f, 50f };
            table.SetWidths(widths);
            table.SpacingBefore = 5f;
            table.DefaultCell.Border = Rectangle.NO_BORDER;
            table.AddCell(new Paragraph("Forma płatności: \t", new Font(bf, SMALL_FONT_SIZE)));
            table.AddCell(new Paragraph("przelew bankowy", new Font(bf, SMALL_FONT_SIZE)));
            table.AddCell("");
            table.AddCell(new Paragraph("Numer konta: \t", new Font(bf, SMALL_FONT_SIZE)));
            table.AddCell(new Paragraph("00 1111 2222 3333 4444 5555", new Font(bf, SMALL_FONT_SIZE)));
            table.AddCell("");
            table.AddCell(new Paragraph("Termin płatności: \t", new Font(bf, SMALL_FONT_SIZE)));
            table.AddCell(new Paragraph("2016-07-10", new Font(bf, SMALL_FONT_SIZE)));
            table.AddCell("");
            table.AddCell(new Paragraph("Do zapłaty: \t", new Font(bf, SMALL_FONT_SIZE)));
            table.AddCell(new Paragraph("10293.92 zł", new Font(bf, SMALL_FONT_SIZE)));
            table.AddCell("");
            table.AddCell(new Paragraph("Słownie: \t", new Font(bf, SMALL_FONT_SIZE)));
            table.AddCell(new Paragraph(DecimalToWords.Convert(10293.92m), new Font(bf, SMALL_FONT_SIZE)));
            table.AddCell("");
            doc.Add(table);
            // ------------------


            doc.Close();
            Mail mail = new Mail(pdfName);

        }
    }
}
