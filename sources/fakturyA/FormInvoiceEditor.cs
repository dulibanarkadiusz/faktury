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
    public partial class FormInvoiceEditor : Form
    {
        private List<string> productCodesOnInvoice = new List<string>();
        private List<ArticleOnInvoice> addedArticlesToInvoice = new List<ArticleOnInvoice>();
        private bool formLoaded = false;

        private List<string> queryList = new List<string>();
        private Invoice editInvoice;
        public Invoice EditInvoice
        {
            get
            {
                return editInvoice;
            }
            set
            {
                editInvoice = value;
            }
        }

        private void AddNewInvoice_Load(object sender, EventArgs e)
        {
            
        }

        private void SetDefaultValues()
        {
            dateTimePickerDateInvoice.MaxDate = DateTime.Now;
            dateTimePickerDateInvoice.MinDate = DateTime.Now.AddDays(-14);
            dateTimePickerDatePayment.MaxDate = DateTime.Now.AddDays(30);
            dateTimePickerDatePayment.MinDate = DateTime.Now.AddDays(-14);
            comboBoxPayMethod.SelectedIndex = 1;
            comboBoxSelectPaymentDate.SelectedIndex = 1;
        }

        public FormInvoiceEditor() // konstruktor bezargumentowy, pozwala uruchomić edytor do utworzenia nowej faktury
        {
            InitializeComponent();
            editInvoice = new Invoice();
            SetDefaultValues();
        }


        public FormInvoiceEditor(Invoice invoice) // konstruktor pozwalający uruchomić edytor w trybie edycji już istniejącej faktury
        {
            InitializeComponent();
            EditInvoice = invoice;
            MainProgram.InvoiceEditor = this;

            GetAndWriteArticlesToInvoiceEditor();
            formLoaded = true;
               

            // odczytaj dane z istniejącej krotki (zapisanej w liście faktur) i wypisz do edytora
            textBoxInvoiceNumber.Text = invoice.Number;
            comboBoxPayMethod.Text = invoice.PaymentMethod;
            dateTimePickerDateInvoice.Text = invoice.InvoiceDate.ToString();
            dateTimePickerDateSale.Text = invoice.SellingDate.ToString();
            dateTimePickerDatePayment.Text = invoice.PaymentDate.ToString();
            textBoxAmountPaid.Text = invoice.AmountPaid.ToString();
            
            WriteTotalInvoiceValue();
            GetAndLoadCustomerDetails();
        }

        public void WriteTotalInvoiceValue()
        {
            labelInvoiceTotalNetto.Text = EditInvoice.InvoiceTotalNetto.ToString() + " zł";
            labelInvoiceValue.Text = EditInvoice.InvoiceValue.ToString() + " zł";
        }

        private void GetAndWriteArticlesToInvoiceEditor()
        {
            if (EditInvoice.InvoiceTotalNetto < 0.01m)
            {
                DatabaseMySQL.LoadPositionsOnInvoice(editInvoice);
            }
            else
            {
                foreach (ArticleOnInvoice articleOnInvoice in editInvoice.ArticlesOnInvoiceList)
                {
                    WriteArticleOnInvoice_ToDataGridView(articleOnInvoice);
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // zmieniono termin płatności
            // podstawowa operacja to odpowiednio zmienić obiekt + przeliczyć datę na kalendarzu
            dateTimePickerDatePayment.Enabled = false;
            string selectedValue_DatePayment = (sender as ComboBox).Text;

            if (selectedValue_DatePayment == "7 dni")
                dateTimePickerDatePayment.Value = (Convert.ToDateTime(dateTimePickerDateSale.Value)).AddDays(7);
            else if (selectedValue_DatePayment == "14 dni")
                dateTimePickerDatePayment.Value = (Convert.ToDateTime(dateTimePickerDateSale.Value)).AddDays(14);
            else if (editInvoice.Number == null)
            {
                dateTimePickerDatePayment.Value = DateTime.Now;
                dateTimePickerDatePayment.Enabled = true;
            }
        }


        private void buttonAddArticleToInvoice_Click(object sender, EventArgs e)
        {
            FormArticles addingArticleToInvoice_Window = new FormArticles();
            addingArticleToInvoice_Window.ShowWindowToAddNewArticle();
        }


        public void AddArticleToInvoice(ArticleOnInvoice article)
        {
            if (!productCodesOnInvoice.Contains(article.Article.Code))
            {
                editInvoice.AddArticlePositionToInvoice(article);
                WriteArticleOnInvoice_ToDataGridView(article);
                productCodesOnInvoice.Add(article.Article.Code);
               
                if (formLoaded)
                {
                    // jeśli już jest po załadowaniu istniejącej faktury, a dodawany jest [przez użytkownika] nowy artykuł : 
                    MessageBox.Show("ok");
                    queryList.Add(article.GetInsertQuery());
                }
            }
            else
            {
                MessageBox.Show("Ten produkt występuje już na fakturze i nie można go dodać ponownie.\nWybierz element na liście, a następnie dokonaj stosownych poprawek.");
            }
        }

        public void WriteArticleOnInvoice_ToDataGridView(ArticleOnInvoice article)
        {
            dataGridView1.Rows.Add(article.Article.Code, article.Article.Name, article.Article.PriceNetto + MainProgram.CurrencySymbol, article.Article.VATvalue, article.Article.PriceBrutto + MainProgram.CurrencySymbol, article.Discount + " %", article.Amount, article.Article.UnitMeasure, article.ValueNetto + MainProgram.CurrencySymbol, article.ValueBrutto + MainProgram.CurrencySymbol);
        }

        private void ButtonSaveInvoice_Click(object sender, EventArgs e)
        {
            // Zapis lub uaktualnienie aktualnie otwartej faktury
            if (ValidateForm() == false)
                return;

            MessageBox.Show("ID klienta: " + editInvoice.Customer.CustomerID);

            ReadFormValues();

            string query; bool isNewInvoice = false;
            if (editInvoice.Number == null)
            {
                // zapis nowej faktury 
                isNewInvoice = true;
                editInvoice.Number = DatabaseMySQL.CreateNumberForNewInvoice();
                textBoxInvoiceNumber.Text = editInvoice.Number; // wypisz wygenerowany dla faktury numer 
                query = editInvoice.GenerateInsertQuery();
                foreach (ArticleOnInvoice invoiceArticle in EditInvoice.ArticlesOnInvoiceList)
                {
                    queryList.Add(invoiceArticle.GetInsertQuery());
                }
            }
            else
            {
                /// AKTUALIZACJA (UPDATE) istniejącej faktury
                query = editInvoice.GenerateUpdateQuery(); // przygotowuje zapytanie UPDATE do bazy danych
                
                foreach (string query_text in queryList)
                {
                    DatabaseMySQL.ExecuteQuery(query_text);
                }
                
                addedArticlesToInvoice.Clear();
                
            }
            queryList.Clear(); // czyszczenie historii 

            int? returnValue = null;
            returnValue = DatabaseMySQL.ExecuteQuery(query);
            foreach (string mysqlQuery in queryList)
            {
                DatabaseMySQL.ExecuteQuery(mysqlQuery);
            }


            if (returnValue > 0)
            {
                if (isNewInvoice)
                    MainProgram.InvoiceObjectsList.Add(editInvoice);
                MainProgram.InvoiceWindow.UpdateInvoicesList();
                MessageBox.Show("Operacja wykonana pomyślnie (" + returnValue + ")");
                queryList.Clear();
            }
            else
            {
                MessageBox.Show("Wystąpił błąd.");
            }

        }


        private void buttonChooseCustomer_Click(object sender, EventArgs e)
        {
            if (editInvoice.Number == null)
            {
                FormCustomers SelectCustomerID = new FormCustomers();
                SelectCustomerID.ukryj(true);
                editInvoice.Customer = SelectCustomerID.ChooseConsumerWindow();

                MessageBox.Show("Wybrano id: " + editInvoice.Customer.CustomerID);
                editInvoice.CustomerID = editInvoice.Customer.CustomerID;
                GetAndLoadCustomerDetails();
            }
            else
            {
                MessageBox.Show("Nie można zmienić kontrahenta dla już zapisanej faktury.");
            }
        }


        private void buttonRemoveArticleFromInvoice_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Czy na pewno chcesz usunąć?", "Potwierdź wybór", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                    return;

                productCodesOnInvoice.Remove(dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[0].Value.ToString());
                queryList.Add(EditInvoice.FindAndGetArticleOnInvoice(dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[0].Value.ToString()).GetDeleteQuery());
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("Nie zaznaczono nic do usunięcia.");
            }
        }


        private void GetAndLoadCustomerDetails()
        {
            if (editInvoice.Customer != null)
            {
                labelCustomerName.Text = editInvoice.Customer.CompanyName;
                labelCustomerAdress.Text = String.Format("{0}\n{1} {2}", editInvoice.Customer.Address, editInvoice.Customer.Code, editInvoice.Customer.City);
                labelCustomerNIP.Text = editInvoice.Customer.CustomerNIP;
            }
        }


        private void dateTimePickerDatePayment_ValueChanged(object sender, EventArgs e)
        {
            DateTime sellDate = Convert.ToDateTime(dateTimePickerDateSale.Value);
            DateTime paymentDate = Convert.ToDateTime(dateTimePickerDatePayment.Value);

            if (sellDate.AddDays(14) == paymentDate)
            {
                comboBoxSelectPaymentDate.SelectedIndex = 1;
            }
            else if (sellDate.AddDays(7) == paymentDate)
            {
                comboBoxSelectPaymentDate.SelectedIndex = 0;
            }
            else
            {
                comboBoxSelectPaymentDate.SelectedIndex = 2;
            }

        }

        private void ReadFormValues()
        {
            editInvoice.PaymentDate = dateTimePickerDatePayment.Value;
            editInvoice.InvoiceDate = dateTimePickerDateInvoice.Value;
            editInvoice.SellingDate = dateTimePickerDateSale.Value;
            editInvoice.PaymentMethod = comboBoxPayMethod.Text;
        }



        private bool ValidateForm()
        {
            if (editInvoice.Customer == null)
            {
                errorProvider1.SetError(groupBox1, "Należy wybrać kontrahenta.");
                return false;
            }
            else
            {
                errorProvider1.SetError(groupBox1, "");
            }

            if (dataGridView1.Rows.Count == 0)
            {
                errorProvider1.SetError(dataGridView1, "Dodaj minimum 1 artykuł do faktury.");
                return false;
            }
            else
            {
                errorProvider1.SetError(dataGridView1, "");
            }

            decimal amountPaid;
            if (Decimal.TryParse(textBoxAmountPaid.Text, out amountPaid))
            {
                editInvoice.AmountPaid = amountPaid;
                errorProvider1.SetError(textBoxAmountPaid, "");
            }
            else
            {
                errorProvider1.SetError(textBoxAmountPaid, "Podaj wartość w odpowiednim formacie.");
                return false;
            }

            return true;
        }


        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void buttonEditArticleOnInvoice_Click(object sender, EventArgs e)
        {
            ArticleOnInvoice editedItem = editInvoice.ArticlesOnInvoiceList[dataGridView1.SelectedRows[0].Index];
            FormArticleAmount w = new FormArticleAmount(ref editedItem);
            editInvoice.ArticlesOnInvoiceList[dataGridView1.SelectedRows[0].Index] = editedItem;
            w.StartPosition = FormStartPosition.Manual;
            w.Location = new Point(this.Location.X + 350, this.Location.Y + 150);
            w.ShowDialog();

            // po uzyskaniu odpowiedzi z okna edycji ilości:
            // 1) oznacz jako artykuł do zaktualizowania 
            //if (editInvoice.Number != null )
           // {
                // o ile faktura była już w ogóle zapisywana
                // o ile ten artykuł 
                queryList.Add(editInvoice.ArticlesOnInvoiceList[dataGridView1.SelectedRows[0].Index].GetUpdateQuery());
          //  }

            // 2) uaktualnij okno
            dataGridView1.Rows.Clear();
            GetAndWriteArticlesToInvoiceEditor();
        }

    }
}
