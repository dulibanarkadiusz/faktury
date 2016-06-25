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
            int mouseOnRow = dataGridView1.HitTest(e.X, e.Y).RowIndex;
            if (mouseOnRow >= 0 && EditMode)
            {
                ContextMenu a = new ContextMenu();
                // a.MenuItems.Add(new MenuItem(string.Format("Edytuj", dataGridView1.Rows[mouseOnRow].Cells["Kod"].Value), new EventHandler(this.editArticle_click)));
                // a.MenuItems.Add(new MenuItem(string.Format("Usuń", dataGridView1.Rows[mouseOnRow].Cells["NazwaFirmy"].Value), new EventHandler(this.DeleteCustomer)));
                a.Show(dataGridView1, new Point(e.X, e.Y));
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void button1_Click(object sender, EventArgs e)
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

    }
}
