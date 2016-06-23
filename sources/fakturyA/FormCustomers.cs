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


        public FormCustomers()
        {
            InitializeComponent();
            ukryj(false);
            WriteAllCustomer();

            
        }

        public int ChooseConsumerWindow()
        {
            this.ShowDialog();
            return SelectedConsumerID; // przekaż na wyjście ID zaznaczonego rekordu. 
            // ktoś nie zaznaczył nic -> zwróć:  -1
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void WriteAllCustomer()
        {
            dataGridView1.Rows.Clear(); // wyczyść poprzednie dane nim załadujesz
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

        private void buttonSel_Click(object sender, EventArgs e)
        {
            SelectedConsumerID = dataGridView1.SelectedRows[0].Index;
            this.Close();
        }

       
    }
}
