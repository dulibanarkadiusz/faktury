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
        private bool check_filling = false;
        private bool check_code_in_list = false;

        public FormArticlesEditor()
        {

            InitializeComponent();

            FormArticleEditor_Button.Text = "Dodaj";
            editArticle = new Article();
            PriceNetto_RB.Checked = true;
            Measure_CB.SelectedIndex = 0;
            Vat_CB.SelectedIndex = 0;
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
            Check_well_filled();
            check_code();
            if (check_filling == true)
            {

                if (PriceNetto_RB.Checked)
                {
                    decimal brutto = System.Decimal.Round(Convert.ToDecimal(PriceNetto_TB.Text.Replace('.', ',')), 2);
                    decimal vat = Convert.ToDecimal(Vat_CB.Text);
                    brutto = System.Decimal.Round(brutto + brutto * (vat / 100), 2);
                    PriceBrutto_TB.Text = Convert.ToString(brutto);
                    check_filling = false;
                }
                else if (PriceBrutto_RB.Checked)
                {
                    decimal netto = System.Decimal.Round(Convert.ToDecimal(PriceBrutto_TB.Text.Replace('.', ',')), 2);
                    decimal vat = Convert.ToDecimal(Vat_CB.Text);
                    netto = System.Decimal.Round(netto - netto * (vat / 100), 2);
                    PriceNetto_TB.Text = Convert.ToString(netto);
                    check_filling = false;
                }
                else
                {
                    decimal netto = System.Decimal.Round(Convert.ToDecimal(PriceBrutto_TB.Text.Replace('.', ',')), 2);
                    decimal vat = Convert.ToDecimal(Vat_CB.Text);
                    netto = System.Decimal.Round(netto - netto * (vat / 100), 2);
                    PriceNetto_TB.Text = Convert.ToString(netto);
                    decimal brutto = System.Decimal.Round(Convert.ToDecimal(PriceNetto_TB.Text.Replace('.', ',')), 2);
                    brutto = System.Decimal.Round(brutto + brutto * (vat / 100), 2);
                    PriceBrutto_TB.Text = Convert.ToString(brutto);
                    check_filling = false;
                }
            }


        }
        private void Check_well_filled()
        {
            string CodeTB = Code_TB.Text.Trim();
            string NameTB = Name_TB.Text.Trim();
            string brutto = "brutto";
            string netto = "netto";
            if (PriceBrutto_RB.Checked)
            {
                brutto = PriceBrutto_TB.Text.Trim();
            }
            else
            {
                netto = PriceNetto_TB.Text.Trim();
            }

            if (CodeTB != "" && NameTB != "" && brutto != "" && netto != "")
            {
                check_filling = true;
            }
            else
            {
                if (CodeTB == "")
                    errorProvider1.SetError(Code_TB, "Wpisz Ilość");
                if (NameTB == "")
                    errorProvider1.SetError(Name_TB, "Wpisz Ilość");
                if (brutto == "")
                    errorProvider1.SetError(PriceBrutto_TB, "Wpisz Ilość");
                if (netto == "")
                    errorProvider1.SetError(PriceNetto_TB, "Wpisz Ilość");
            }

        }
        private void check_code()
        {
            foreach (Article a in FormArticles.articlesList)
            {
                if (a.Code == Code_TB.Text)
                {
                    check_code_in_list = false;
                    break;
                }
                check_code_in_list = true;

            }

        }
        private void button1_Click(object sender, EventArgs e)
        {

            Check_well_filled();
            check_code();
            if (check_filling == true)
            {

                if (FormArticleEditor_Button.Text == "Dodaj")
                {
                    if (check_code_in_list == true)
                    {
                        editArticle.Code = Code_TB.Text;
                        editArticle.Name = Name_TB.Text;
                        editArticle.UnitMeasure = Measure_CB.Text;
                        editArticle.VATvalue = Convert.ToDecimal(Vat_CB.Text);

                        if (PriceBrutto_RB.Checked)
                        {
                            editArticle.PriceBrutto = System.Decimal.Round(Convert.ToDecimal(PriceBrutto_TB.Text.Replace('.', ',')), 2);
                            editArticle.PriceNetto = System.Decimal.Round(editArticle.PriceBrutto - editArticle.PriceBrutto * editArticle.VATvalue / 100, 2);
                        }
                        else
                        {
                            editArticle.PriceNetto = System.Decimal.Round(Convert.ToDecimal(PriceNetto_TB.Text.Replace('.', ',')), 2);
                            editArticle.PriceBrutto = System.Decimal.Round(editArticle.PriceNetto + editArticle.PriceNetto * editArticle.VATvalue / 100, 2);
                        }
                        FormArticles.articlesList.Add(editArticle);
                        editArticle.GenerateQueryInsertArticles();
                        DatabaseMySQL.ExecuteQuery(editArticle.GenerateQueryInsertArticles());
                        MainProgram.ArticlesWindow.AddRowsToDataGridView(editArticle);
                        check_filling = false;
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Artykuł o podanym kodzie już istnieje");
                    }
                }
                else
                {

                    editArticle.Name = Name_TB.Text;
                    editArticle.UnitMeasure = Measure_CB.Text;
                    editArticle.VATvalue = Convert.ToDecimal(Vat_CB.Text);
                    editArticle.Name = Name_TB.Text;
                    if (PriceBrutto_RB.Checked)
                    {

                        editArticle.PriceBrutto = System.Decimal.Round(Convert.ToDecimal(PriceBrutto_TB.Text), 2);
                        editArticle.PriceNetto = System.Decimal.Round(editArticle.PriceBrutto - editArticle.PriceBrutto * editArticle.VATvalue / 100, 2);
                    }
                    else
                    {
                        editArticle.PriceNetto = System.Decimal.Round(Convert.ToDecimal(PriceNetto_TB.Text), 2);
                        editArticle.PriceBrutto = System.Decimal.Round(editArticle.PriceNetto + editArticle.PriceNetto * editArticle.VATvalue / 100, 2);
                    }
                    editArticle.GenerateQueryUpdateArticles();
                    DatabaseMySQL.ExecuteQuery(editArticle.GenerateQueryUpdateArticles());
                    MainProgram.ArticlesWindow.ReplaceEditRowArticleInDataGrid(editArticle);
                    //szukanie w articlelist po indexie
                    // datagrid.view.rows[inex]
                    check_filling = false;
                    Close();
                }
            }
        }

        private void PriceBrutto_TB_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == '.' || e.KeyChar == ',')
            {
                if (e.KeyChar == ',' || e.KeyChar == '.')
                {

                    if (PriceBrutto_TB.Text.Contains(',') || PriceNetto_TB.Text.Contains(',') || PriceNetto_TB.Text.Contains('.') || PriceBrutto_TB.Text.Contains('.'))
                    {
                        e.Handled = true;

                    }
                    else
                        base.OnKeyPress(e);
                }

            }
            else
                e.Handled = true;
        }


    }
}
