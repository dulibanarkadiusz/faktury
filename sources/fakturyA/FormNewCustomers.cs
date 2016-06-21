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
    public partial class FormNewCustomers : Form
    {
        public FormNewCustomers()
        {
            InitializeComponent();
        }
        private void clearTextBox()
        {
            BoxAddress.Clear();
            BoxCity.Clear();
            BoxCode1.Clear();
            BoxNIP.Clear();
            BoxEmail.Clear();
            BoxCustName.Clear();
            BoxCompName.Clear();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string[] s = { BoxCompName.Text, BoxCustName.Text, BoxAddress.Text, BoxCity.Text, BoxCode1.Text + BoxCode2.Text, BoxEmail.Text, BoxNIP.Text };
            Customers newCustomer = new Customers(s);
            bool empty_company = String.IsNullOrEmpty(BoxCompName.Text);
            bool empty_customer = String.IsNullOrEmpty(BoxCustName.Text);
            if ((empty_company == true) && (empty_customer == true))
            {
                errorProvider1.SetError(label9, "wypełnij jedno z wymaganych pól");
            }
            else
            {
                errorProvider1.Clear();
                string query = newCustomer.GenerateInsertQuery();
                DatabaseMySQL.ExecuteQuery(query);

            }
            clearTextBox();
            this.Close();
        }

    }
}
