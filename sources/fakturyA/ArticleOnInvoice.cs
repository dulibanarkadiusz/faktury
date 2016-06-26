using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fakturyA
{
    public class ArticleOnInvoice
    {
        private decimal discount;
        private decimal amount; 

        public Article Article { get; private set; }
        public decimal Discount { get{ return discount; }
            set
            {
                discount = value;
                UpdateValues();
            }
        }
        public decimal Amount { get{ return amount; }
            set
            {
                amount = value;
                UpdateValues();
            }
        }
        public decimal ValueNetto { get; private set; }
        public decimal ValueBrutto { get; private set; }

        public ArticleOnInvoice(Article article, decimal discount, decimal amount)
        {
            Article = article;
            Discount = discount;
            Amount = amount; 
        }

        private void UpdateValues()
        {
            ValueNetto = Math.Round(Amount * (1-Discount*0.01m) * Article.PriceNetto,2);
            ValueBrutto = Math.Round(Amount * (1-Discount*0.01m) * Article.PriceBrutto,2);
        }

        public string GetInsertQuery()
        {
            return String.Format("INSERT INTO pozycja_faktury SET kod_Artykulu='{0}', nr_faktury='{1}', ilosc='{2}', rabat='{3}', cena='{4}'", Article.Code, MainProgram.InvoiceEditor.EditInvoice.Number, Amount, Discount, Article.PriceBrutto*(1-Discount*0.01m));
        }

        public string GetDeleteQuery()
        {
            return String.Format("DELETE FROM pozycja_faktury WHERE kod_artykulu='{0}' AND nr_faktury='{1}'", Article.Code, MainProgram.InvoiceEditor.EditInvoice.Number);
        }

        public string GetUpdateQuery()
        {
            return String.Format("UPDATE pozycja_faktury SET ilosc='{0}', rabat='{1}', cena='{2}' WHERE kod_artykulu='{3}' AND nr_faktury='{4}'", Amount, Discount, Article.PriceBrutto*(1-Discount*0.01m), Article.Code, MainProgram.InvoiceEditor.EditInvoice.Number);
        }
    }
}
