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
    public partial class FormCustomers : Form
    {

        private int SelectedConsumerID { get; set; }
        public bool EditMode { get; set; }

        public FormCustomers()
        {
            InitializeComponent();
            ukryj(false);
            WriteAllCustomer();
            SelectedConsumerID = -1;
        }

        public Customers ChooseConsumerWindow()
        {
            this.ShowDialog();
            if (SelectedConsumerID >= 0)
            {
                return MainProgram.CustomersList[SelectedConsumerID];
            }
            else
            {
                return null;
            }
       
        }
        public void ukryj(bool ktory)
        {
            if (ktory == true)
            {
                
                buttonAdd.Hide();
                buttonSel.Show();
            }
            else
            {
                buttonAdd.Show();
                buttonSel.Hide();
            }

        }
        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            
                // context menu 
                // int mouseOnRow = dataGridView1.HitTest(e.X, e.Y).RowIndex;
                // if (mouseOnRow >= 0 && EditMode)
            int currentMouseOverRow = dataGridView1.HitTest(e.X, e.Y).RowIndex;
            if (currentMouseOverRow >= 0 && e.Button == MouseButtons.Left)
                {
                    ContextMenu m = new ContextMenu();
                    m.MenuItems.Add(new MenuItem(string.Format("Edytuj"), new EventHandler(this.Edit_click)));
                    m.MenuItems.Add(new MenuItem(string.Format("Usuń"), new EventHandler(this.Delete_Click)));
                    m.Show(dataGridView1, new Point(e.X, e.Y));
                }
            
        }

        private void WriteAllCustomer()
        {
            MainProgram.CustomersList.Clear(); // wyczyść poprzednie dane nim załadujesz
            DatabaseMySQL.LoadCustomerList();

            if (MainProgram.CustomersList.Count > 0) // jeśli tablica nie-pusta
            {
                int i = 0;
                foreach (Customers customer in MainProgram.CustomersList)
                {
                    dataGridView1.Rows.Add();
                    DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[i];


                    row.Cells["NazwaFirmy"].Value = customer.CompanyName;
                    row.Cells["Klient"].Value = customer.CustomerName;
                    row.Cells["ulica"].Value = customer.Address;
                    row.Cells["miasto"].Value = customer.City;
                    row.Cells["kod_poczt"].Value = customer.Code;
                    row.Cells["email"].Value = customer.Email;
                    row.Cells["NIP"].Value = customer.CustomerNIP;
                    i++;
                }
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormNewCustomers AddNew = new FormNewCustomers();
            AddNew.ShowDialog();
            dataGridView1.Rows.Clear();
            WriteAllCustomer();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                int rowIndeks = dataGridView1.SelectedRows[0].Index;
                Customers customer = MainProgram.CustomersList[rowIndeks];
                DatabaseMySQL.ExecuteQuery(customer.GenerateQueryDropCustomer());
                dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);
                MessageBox.Show("Kontrahent został usunięty poprawnie");
            }
        }

        private void buttonSel_Click(object sender, EventArgs e)
        {

            SelectedConsumerID = this.dataGridView1.SelectedRows[0].Index;
            this.Close();
        }
        private void Edit_click(object sender, EventArgs e)
        {
            List<Customers> cust = MainProgram.CustomersList;
            FormNewCustomers edit = new FormNewCustomers(cust[dataGridView1.SelectedRows[0].Index]);
            edit.Text = "Edytuj";
            edit.ShowDialog();
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
    }
}
