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
    //TEST
    public partial class FormNewCustomers : Form
    {
        bool isSecurity = false;
        public FormNewCustomers()
        {
            InitializeComponent();
            button2.Hide();
        }
        private void clearTextBox()
        {
            BoxAddress.Clear();
            BoxCity.Clear();
            BoxCode1.Clear();
            BoxCode2.Clear();
            BoxNIP.Clear();
            BoxEmail.Clear();
            BoxCustName.Clear();
            BoxCompName.Clear();
        }
        public FormNewCustomers(Customers customer)
        {
            InitializeComponent();
            button1.Hide();
            Customers editCustomer = new Customers();
            BoxCompName.Text = customer.CompanyName;
            BoxCustName.Text = customer.CustomerName;
            BoxAddress.Text = customer.Address;
            BoxCity.Text = customer.City;
            BoxCode1.Text = Convert.ToString(customer.Code).Substring(0, 2);
            BoxCode2.Text = Convert.ToString(customer.Code).Remove(0, 2);
            BoxEmail.Text = customer.Email;
            BoxNIP.Text = customer.CustomerNIP;

        }
        private void Security()
        {
            bool empty_company = String.IsNullOrEmpty(BoxCompName.Text);
            bool empty_customer = String.IsNullOrEmpty(BoxCustName.Text);
            bool empty_address = String.IsNullOrEmpty(BoxAddress.Text);
            bool empty_city = String.IsNullOrEmpty(BoxCity.Text);
            bool empty_code1 = String.IsNullOrEmpty(BoxCode1.Text);
            bool empty_code2 = String.IsNullOrEmpty(BoxCode2.Text);
            bool empty_email = String.IsNullOrEmpty(BoxEmail.Text);

            if ((empty_company == true) && (empty_customer == true))
                errorProvider1.SetError(label9, "wypełnij jedno z wymaganych pól");
            else if (empty_address == true)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(label3, "wypełnij wymagane pola");
            }
            else if (empty_city == true)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(label4, "wypełnij wymagane pola");
            }
            else if (empty_code1 == true)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(label5, "wypełnij wymagane pola");
            }
            else if (empty_code2 == true)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(label5, "wypełnij wymagane pola");
            }
            else if (empty_email == true)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(label6, "wypełnij wymagane pola");
            }
            else
                isSecurity = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string[] s = { "0", BoxCompName.Text, BoxCustName.Text, BoxAddress.Text, BoxCity.Text, BoxCode1.Text + BoxCode2.Text, BoxEmail.Text, BoxNIP.Text };

            if (isSecurity == false)
            {
                Security();
            }
            else
            {
                errorProvider1.Clear();
                Customers newCustomer = new Customers(s);
                string query = newCustomer.GenerateInsertQuery();
                DatabaseMySQL.ExecuteQuery(query);
                clearTextBox();
                this.Close();
            }

        }


        private void BoxCode1_TextChanged(object sender, EventArgs e)
        {
            BoxCode1.MaxLength = 2;
        }

        private void BoxCode2_TextChanged(object sender, EventArgs e)
        {
            BoxCode2.MaxLength = 3;
        }

        private void BoxNIP_TextChanged(object sender, EventArgs e)
        {
            BoxNIP.MaxLength = 10;
        }

        private void Box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            if (isSecurity == false)
                Security();
            else
            {
                Customers editCustomer = new Customers();
                string query = editCustomer.GenerateQueryUpdateCustomer();
                DatabaseMySQL.ExecuteQuery(query);
                MessageBox.Show("Udalo się");
            }

        }

    }
}
