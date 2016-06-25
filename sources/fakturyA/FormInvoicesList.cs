using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace fakturyA
{
    public partial class FormInvoicesList : Form
    {
        public FormInvoicesList()
        {
            InitializeComponent();
            comboBoxMaximumResults.SelectedIndex = 2;
        }

        private void FormInvoice_Load(object sender, EventArgs e)
        {
            DatabaseMySQL.LoadInvoicesList();
            WriteAllInvoices(MainProgram.InvoiceObjectsList);
        }

        public void UpdateInvoicesList()
        {
            WriteAllInvoices(MainProgram.InvoiceObjectsList);
        }

        private void WriteAllInvoices(List<Invoice> invoiceList)
        {
            dataGridView1.Rows.Clear(); // wyczyść poprzednie dane nim załadujesz
            //DatabaseMySQL.LoadInvoicesList();

            if (invoiceList.Count > 0) // jeśli tablica nie-pusta
            {
                int i = 0;
                foreach (Invoice invoice in invoiceList)
                {
                    dataGridView1.Rows.Add();
                    DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[i];

                    row.Cells["index"].Value = i;
                    row.Cells["NrFaktury"].Value = invoice.Number;
                    row.Cells["sprzedawca"].Value = invoice.EmployeeName;
                    row.Cells["KlientNIP"].Value = invoice.CustomerNIP;
                    row.Cells["KlientName"].Value = invoice.CusotmerName;
                    row.Cells["WartoscFaktury"].Value = invoice.InvoiceValue + MainProgram.CurrencySymbol;
                    row.Cells["DoZaplaty"].Value = invoice.InvoiceValue - invoice.AmountPaid + MainProgram.CurrencySymbol;
                    if (invoice.InvoiceValue > invoice.AmountPaid)
                    {
                        row.Cells["DoZaplaty"].Style.ForeColor = Color.Red;
                        if (invoice.PaymentDate < DateTime.Now)
                        {
                            row.Cells["TerminPlatnosci"].Style.ForeColor = Color.Red;
                        }
                    }
                    else
                    {
                        row.Cells["DoZaplaty"].Value = 0 + MainProgram.CurrencySymbol;
                    }

                    row.Cells["DataWystawienia"].Value = invoice.InvoiceDate.ToString().Remove(MainProgram.DateLength);
                    row.Cells["TerminPlatnosci"].Value = invoice.PaymentDate.ToString().Remove(MainProgram.DateLength);
                    i++;
                }
            }
        }

        private void FindInInvoices(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            var ResultsInvoices = from Invoice invoice in MainProgram.InvoiceObjectsList
                                  where (invoice.Number.Contains(textBoxFindNumber.Text)
                                  && invoice.CusotmerName.Contains(textBoxFindCustomerName.Text))
                                  //&& invoice.CustomerNIP.ToString().Contains(textBoxFindNIP.Text))
                                  select invoice;

            WriteAllInvoices(ResultsInvoices.ToList());
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            // context menu 
            int currentMouseOverRow = dataGridView1.HitTest(e.X, e.Y).RowIndex;
            if (currentMouseOverRow >= 0 && e.Button == MouseButtons.Left)
            {
                ContextMenu m = new ContextMenu();
                m.MenuItems.Add(new MenuItem(string.Format("Edytuj fakturę nr {0}", dataGridView1.Rows[currentMouseOverRow].Cells["NrFaktury"].Value), new EventHandler(this.editInvoice_Click)));
                m.MenuItems.Add(new MenuItem(string.Format("Wyślij na e-mail kontrahenta"), new EventHandler(this.sendPdf_Click)));
                m.MenuItems.Add(new MenuItem(string.Format("Usuń dokument"), new EventHandler(this.removeInvoice_Click)));
                m.Show(dataGridView1, new Point(e.X, e.Y));
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            // nadpisujemy standardową metodę zamykania okna. Zamknięcie okna oznacza standardowo likwidację danego obiektu. 
            // My chcemy zamknąć okno, ale nie kasować go (bo użytkownik może np. ponownie je otworzyć).
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();
            }
        }



        private void sendPdf_Click(object sender, EventArgs e)
        {
            var findNumber = dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells["NrFaktury"].Value.ToString();
            var invoiceObject = (from Invoice invoice in MainProgram.InvoiceObjectsList
                                 where (invoice.Number == findNumber)
                                 select invoice).FirstOrDefault();

            PDFgenerator pdf = new PDFgenerator(invoiceObject);
        }


        private void editInvoice_Click(object sender, EventArgs e)
        {
            var findNumber = dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells["NrFaktury"].Value.ToString();
            var invoiceObject = ( from Invoice invoice in MainProgram.InvoiceObjectsList
                                  where (invoice.Number == findNumber)
                                  select invoice).FirstOrDefault();

            if (invoiceObject != null)
            {
                FormInvoiceEditor w = new FormInvoiceEditor(invoiceObject);
                w.ShowDialog();
            }
            else
            {
                MessageBox.Show("Faktury nie znaleziono.");
            }
        }

        private void removeInvoice_Click(object sender, EventArgs e)
        {
            string dialogText = String.Format("Próbujesz usunąć fakturę nr {0}.\n\nZdecydowanie nie zaleca się usuwania wystawionych dokumentów.\nCzy mimo to chcesz usunąć?", MainProgram.InvoiceObjectsList[dataGridView1.SelectedRows[0].Index].ToString());
            DialogResult result = MessageBox.Show(dialogText, "Ostrzeżenie", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                var findNumber = dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells["NrFaktury"].Value.ToString();
                var invoiceObject = (from Invoice invoice in MainProgram.InvoiceObjectsList
                                     where (invoice.Number == findNumber)
                                     select invoice).FirstOrDefault();

                List<string> transactionMySQL_queryList = new List<string>();
                transactionMySQL_queryList.Add(invoiceObject.GenerateDeleteQuery());
                transactionMySQL_queryList.Add(invoiceObject.GenerateDeleteQueryForArticlesOnInvoice());

                int n = DatabaseMySQL.ExecuteTransaction(transactionMySQL_queryList);
                if (n > 0)
                {
                    dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                    MainProgram.InvoiceObjectsList.Remove(invoiceObject);
                }
                else
                {
                    MessageBox.Show("Nie udało się usunąć faktury.");
                }
            }
        }


        private void WriteInvoice(Invoice invoice)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private int CompareInt_ifLeftIntBigger(int x, int y)
        {
            if (x > y)
            {
                return 1;
            }
            else if (x < y)
            {
                return -1;
            }
            else{
                return 0;
            }
        }

        private void customSortCompare(object sender, DataGridViewSortCompareEventArgs e)
        {
            if (e.Column.Index == 1)
            {
                string[] val1 = e.CellValue1.ToString().Split('/');
                string[] val2 = e.CellValue2.ToString().Split('/');

                int porownajRok = CompareInt_ifLeftIntBigger(Convert.ToInt16(val1[2]), Convert.ToInt16(val2[2]));
                if (porownajRok != 0)
                {
                    e.SortResult = porownajRok;
                }
                else
                {
                    int porownajMiesiac = CompareInt_ifLeftIntBigger(Convert.ToInt16(val1[1]), Convert.ToInt16(val2[1]));
                    if (porownajMiesiac != 0)
                    {
                        e.SortResult = porownajMiesiac;
                    }
                    else
                    {
                        int porownajNumer = CompareInt_ifLeftIntBigger(Convert.ToInt16(val1[0]), Convert.ToInt16(val2[0]));
                        e.SortResult = porownajNumer;
                    }
                }
                e.Handled = true;

            }
            else if (e.Column.Index == 5 || e.Column.Index == 6) // double compare
            {
                var val1 = double.Parse(e.CellValue1.ToString().Replace(" zł", ""));
                var val2 = double.Parse(e.CellValue2.ToString().Replace(" zł", ""));

                if (val1 > val2)
                {
                    e.SortResult = 1;
                }
                else if (val1 < val2)
                {
                    e.SortResult = -1;
                }
                else
                {
                    e.SortResult = 0;
                }

                e.Handled = true;
            }
        }


    }
}
