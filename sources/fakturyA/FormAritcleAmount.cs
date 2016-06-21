using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fakturyA
{
    public partial class FormArticleAmount : Form
    {
         public int Amount { get; set; }
        public double Discount { get; set; }
        private int indeks;
        public FormArticleAmount(int indeks)
        {
            this.indeks=indeks;
            InitializeComponent();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();
            }


        }
        private void Add_Click(object sender, EventArgs e)
        {
            Amount_TB.Text = Amount_TB.Text.Trim().ToString();
            Discount_TB.Text = Discount_TB.Text.Trim().ToString();
            if (Discount_TB.Text != "" && Amount_TB.Text != "")
            {
                //poprawić sprawdzanie co wpisali 
                // ideeexxxxx 
                FormArticles.articlesList[indeks].Discount = Convert.ToDecimal(Discount_TB.Text);
               FormArticles.articlesList[indeks].Amount = Convert.ToInt32(Amount_TB.Text);
               // MessageBox.Show(Convert.ToString(indeks + " " + FormArticles.articlesList[indeks].Amount + " " + Convert.ToString(FormArticles.articlesList[indeks].Discount)));
            }
            // MainProgram.AddArticletoInvoiceWindow.
            // MainProgram.AddArticletoInvoiceWindow.Close();
            /* POPRAWECZKI ARECZKA --- tam na dole \/ */
            ArticleOnInvoice pos = new ArticleOnInvoice(FormArticles.articlesList[indeks], Convert.ToDecimal(Discount_TB.Text), Convert.ToDecimal(Amount_TB.Text));
            MainProgram.InvoiceEditor.AddArticleToInvoice(pos);
            Close();
          

        }

        
    }
}
  