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
    public partial class FormArticlesEditor : Form
    {
        private Article editArticle;

        public FormArticlesEditor()
        {

            InitializeComponent();

            FormArticleEditor_Button.Text = "Dodaj";
            editArticle = new Article();
            PriceNetto_RB.Checked = true;
        }
        public FormArticlesEditor(Article article)
        {

            InitializeComponent();
            PriceNetto_RB.Checked = true;
            FormArticleEditor_Button.Text = "Zmień";
            editArticle = article;
            Code_TB.Text = article.Code;
            Code_TB.Enabled = false;
            Vat_CB.Text = Convert.ToString(article.VATvalue);
            PriceNetto_TB.Text = Convert.ToString(article.PriceNetto);
            PriceBrutto_TB.Text = Convert.ToString(article.PriceBrutto);
            Measure_CB.Text = article.UnitMeasure;
            Name_TB.Text = article.Name;
        }
        public void checkedRadioButton(object sender, EventArgs e)
        {
            if (PriceBrutto_RB.Checked)
            {
                PriceNetto_TB.Enabled = false;
                PriceBrutto_TB.Enabled = true;

            }
            else
            {
                PriceBrutto_TB.Enabled = false;
                PriceNetto_TB.Enabled = true;

            }
        }
        public void changeDataInTB(object sender, EventArgs e)
        {
            if (PriceNetto_RB.Checked)
            {
                decimal brutto = Convert.ToDecimal(PriceNetto_TB.Text);
                decimal vat = Convert.ToDecimal(Vat_CB.Text);
                brutto = System.Decimal.Round(brutto + brutto * (vat / 100), 2);
                PriceBrutto_TB.Text = Convert.ToString(brutto);
            }
            else if (PriceBrutto_RB.Checked)
            {
                decimal netto = Convert.ToDecimal(PriceBrutto_TB.Text);
                decimal vat = Convert.ToDecimal(Vat_CB.Text);
                netto = System.Decimal.Round(netto - netto * (vat / 100), 2);
                PriceNetto_TB.Text = Convert.ToString(netto);
            }
            else
            {
                decimal netto = Convert.ToDecimal(PriceBrutto_TB.Text);
                decimal vat = Convert.ToDecimal(Vat_CB.Text);
                netto = System.Decimal.Round(netto - netto * (vat / 100), 2);
                PriceNetto_TB.Text = Convert.ToString(netto);
                decimal brutto = Convert.ToDecimal(PriceNetto_TB.Text);
                brutto = System.Decimal.Round(brutto + brutto * (vat / 100), 2);
                PriceBrutto_TB.Text = Convert.ToString(brutto);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (FormArticleEditor_Button.Text == "Dodaj")
            {
                editArticle.Code = Code_TB.Text;
                editArticle.Name = Name_TB.Text;
                editArticle.UnitMeasure = Measure_CB.Text;
                editArticle.VATvalue = Convert.ToDecimal(Vat_CB.Text);
                editArticle.Name = Name_TB.Text;
                if (PriceBrutto_RB.Checked)
                {
                    editArticle.PriceBrutto = Convert.ToDecimal(PriceBrutto_TB.Text);
                    editArticle.PriceNetto = System.Decimal.Round(editArticle.PriceBrutto - editArticle.PriceBrutto * editArticle.VATvalue / 100, 2);
                }
                else
                {
                    editArticle.PriceNetto = Convert.ToDecimal(PriceNetto_TB.Text);
                    editArticle.PriceBrutto = System.Decimal.Round(editArticle.PriceNetto + editArticle.PriceNetto * editArticle.VATvalue / 100, 2);
                }
                FormArticles.articlesList.Add(editArticle);
                editArticle.GenerateQueryInsertArticles();
                MessageBox.Show(editArticle.Code + editArticle.Name);
                DatabaseMySQL.ExecuteQuery(editArticle.GenerateQueryInsertArticles());
                MainProgram.ArticlesWindow.AddRowsToDataGridView(editArticle);
                Close();

            }
            else
            {

                editArticle.Name = Name_TB.Text;
                editArticle.UnitMeasure = Measure_CB.Text;
                editArticle.VATvalue = Convert.ToDecimal(Vat_CB.Text);
                editArticle.Name = Name_TB.Text;
                if (PriceBrutto_RB.Checked)
                {
                    editArticle.PriceBrutto = Convert.ToDecimal(PriceBrutto_TB.Text);
                    editArticle.PriceNetto = System.Decimal.Round(editArticle.PriceBrutto - editArticle.PriceBrutto * editArticle.VATvalue / 100, 2);
                }
                else
                {
                    editArticle.PriceNetto = Convert.ToDecimal(PriceNetto_TB.Text);
                    editArticle.PriceBrutto = System.Decimal.Round(editArticle.PriceNetto + editArticle.PriceNetto * editArticle.VATvalue / 100, 2);
                }
                editArticle.GenerateQueryUpdateArticles();
                MessageBox.Show(editArticle.Code + editArticle.Name);
                DatabaseMySQL.ExecuteQuery(editArticle.GenerateQueryUpdateArticles());
                MainProgram.ArticlesWindow.ReplaceEditRowArticleInDataGrid(editArticle);
                //szukanie w articlelist po indexie
                // datagrid.view.rows[inex]
                Close();

            }
        }




    }
}
