using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace fakturyA
{
    public class Article
    {
        public string Code { get; set; }
        public string Name { get;  set; }
        public decimal PriceNetto { get;  set; }
        public decimal PriceBrutto { get; set; }
        public decimal VATvalue { get; set; }
        public int Amount { get; set; } //ilosc
        public string UnitMeasure { get;  set; }// jednostka miary
        public double Discount { get; set; }//obniżka

        public Article()
        {
            Code = "";
            Name = "";
            PriceNetto = 0;
            PriceBrutto = 0;
            VATvalue = 0;
            UnitMeasure = "usluga";
            Discount = 0.0;
            Amount = 0;
        }
        public Article(string[] row)
        {
            Code = row[0];
            Name = row[4];
            PriceNetto =Convert.ToDecimal(row[1]);
            VATvalue = Convert.ToDecimal(row[3]);
            
            PriceBrutto = System.Decimal.Round(PriceNetto +PriceNetto* (VATvalue / 100),2);
            UnitMeasure = row[2];

        }
        
        public string GenerateQueryUpdateArticles()
        {
            return String.Format("Update artykul set cena_netto='{0}',jednostkaM='{1}',stawka_VAT='{2}',nazwa='{3}' where kod='{4}'", PriceNetto, UnitMeasure, VATvalue, Name, Code);
        }
        public string GenerateQueryInsertArticles()
        {
            return String.Format("Insert into artykul set kod='{0}', cena_netto='{1}',jednostkaM='{2}',stawka_VAT='{3}',nazwa='{4}'", Code, PriceNetto, UnitMeasure, VATvalue, Name);
        }
        public string GenerateQueryDropArticles()
        {
            return String.Format("Delete from artykul where kod='{0}'", Code);
        }
        
    }
}
