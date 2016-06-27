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
        private bool edit_window;
        private ArticleOnInvoice edit;
        public FormArticleAmount(int indeks)
        {
           
            edit_window = false;
            this.indeks = indeks;
            InitializeComponent();
            button1.Text = "Dodaj Rabat i ilość";
        }
        public FormArticleAmount(ref ArticleOnInvoice a)
        {
            edit_window = true;
            InitializeComponent();
            button1.Text = "Edytuj Rabat i Ilość";
            edit = a;
            Amount_TB.Text = Convert.ToString(a.Amount);
            Discount_TB.Text = Convert.ToString(a.Discount);

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
            if (edit_window == false)
            {
                Amount_TB.Text = Amount_TB.Text.Trim().ToString();
                Discount_TB.Text = Discount_TB.Text.Trim().ToString();
                if (Discount_TB.Text != "" && Amount_TB.Text != ""&&Amount_TB.Text!="0")
                {
                    ArticleOnInvoice pos = new ArticleOnInvoice(FormArticles.articlesList[indeks], Convert.ToDecimal(Discount_TB.Text), Convert.ToDecimal(Amount_TB.Text));
                    MainProgram.InvoiceEditor.AddArticleToInvoice(pos);
                    Close();

                }
                else
                {
                    if (Discount_TB.Text == "")
                        errorProvider1.SetError(Discount_TB, "Wpisz rabat");
                    if (Amount_TB.Text == ""||Amount_TB.Text=="0")
                        errorProvider2.SetError(Amount_TB, "Wpisz Ilość");

                }
            }
                if(edit_window==true)
                {

                    Amount_TB.Text = Amount_TB.Text.Trim().ToString();
                    Discount_TB.Text = Discount_TB.Text.Trim().ToString();
                    if (Discount_TB.Text != "" && Amount_TB.Text != "")
                    {

                        edit.Amount = Convert.ToDecimal(Amount_TB.Text);
                        edit.Discount = Convert.ToDecimal(Discount_TB.Text);
                        edit_window = false;
                        Close();
                    }
                    else
                    {
                        if (Discount_TB.Text == "")
                            errorProvider1.SetError(Discount_TB, "Wpisz rabat");
                        if (Amount_TB.Text == "")
                            errorProvider2.SetError(Amount_TB, "Wpisz Ilość");
                    }
            }
        }

        private void Amount_TB_KeyPress(object sender, KeyPressEventArgs e)
        {
            Amount_TB.MaxLength = 10;
            if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back)
                base.OnKeyPress(e);
            else
                e.Handled = true;
        }

        private void Discount_TB_KeyPress(object sender, KeyPressEventArgs e)
        {
            string s = Discount_TB.Text;
            Discount_TB.MaxLength = 2;


            if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back)
                base.OnKeyPress(e);
            else
                e.Handled = true;


            toolTip1.SetToolTip(this.Discount_TB, "Rabat nie może być wiekszy niż 99%");


        }

        private void Amount_TB_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
