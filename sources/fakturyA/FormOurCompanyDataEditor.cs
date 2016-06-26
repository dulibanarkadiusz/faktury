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
    public partial class FormOurCompanyDataEditor : Form
    {
        OurCompany ourComp = new OurCompany();
        private bool edit = false;
        public FormOurCompanyDataEditor()
        {

            InitializeComponent();
            Code_TB.MaxLength = 5;
            NIP_TB.MaxLength = 10;
            Regon_TB.MaxLength = 14;
            BankAccount1_TB.MaxLength = 26;

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
        private void FormOurCompanyDataEditor_Load(object sender, EventArgs e)
        {

            CompanyName_TB.Text = ourComp.CompanyName;
            City_TB.Text = ourComp.City;
            Code_TB.Text = ourComp.Code;
            PlaceAdres_TB.Text = ourComp.PlaceAddres;
            NIP_TB.Text = ourComp.NIP;
            Regon_TB.Text = ourComp.Regon;
            BankAccount1_TB.Text = ourComp.BankAccount1;
            BankAccount2_TB.Text = ourComp.BankAccount2;

        }
        private void checkedit()
        {
            string comp = CompanyName_TB.Text.Trim();
            string place = PlaceAdres_TB.Text.Trim();
            string nip = NIP_TB.Text.Trim();
            string city = City_TB.Text.Trim();
            string code = Code_TB.Text.Trim();
            string bank = BankAccount1_TB.Text.Trim();
            if (comp != "" && place != "" && nip != "" && city != "" && code != "" && bank != "")
            {


                ourComp.CompanyName = CompanyName_TB.Text;
                ourComp.PlaceAddres = PlaceAdres_TB.Text;
                ourComp.NIP = NIP_TB.Text;
                ourComp.Code = Code_TB.Text;
                ourComp.City = City_TB.Text;
                ourComp.Regon = Regon_TB.Text;
                ourComp.BankAccount1 = BankAccount1_TB.Text;
                ourComp.BankAccount2 = BankAccount2_TB.Text;
                edit = true;
            }
            else
            {
                edit = false;
            }
        }

        private void button_edit_comp_Click(object sender, EventArgs e)
        {
            checkedit();
            if (edit)
            {

                ourComp.EditOurCompany(ourComp);

                edit = false;
                Close();
            }
            else
            {
                MessageBox.Show("Nie wypełniono poprawnie");
            }

        }
    }
}
