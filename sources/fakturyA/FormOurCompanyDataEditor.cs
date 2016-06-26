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
            Code_TB.Mask = "00 000";
            NIP_TB.Mask = "0000000000";
            Regon_TB.Mask = "00000000000000";
            BankAccount1_TB.Mask = "00 0000 0000 0000 0000 0000 0000";
            BankAccount2_TB.Mask = "00 0000 0000 0000 0000 0000 0000";
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
            string city = City_TB.Text.Trim();
            if (comp != "" && place != "" && city != "" && NIP_TB.MaskCompleted && Code_TB.MaskCompleted && BankAccount1_TB.MaskCompleted)
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
                if (CompanyName_TB.Text == "")
                    errorProvider1.SetError(CompanyName_TB, "Wpisz nazwę firmy");
                if (!Code_TB.MaskCompleted)
                    errorProvider1.SetError(Code_TB, "Wpisz kod pocztowy");
                if (!NIP_TB.MaskCompleted)
                    errorProvider1.SetError(NIP_TB, "Wpisz NIP");
                if (City_TB.Text == "")
                    errorProvider1.SetError(City_TB, "Wpisz miasto");
                if (!BankAccount1_TB.MaskCompleted)
                    errorProvider1.SetError(BankAccount1_TB, "Wpisz numer konta bankowego");
                if (PlaceAdres_TB.Text == "")
                    errorProvider1.SetError(PlaceAdres_TB, "Wpisz Adres");

            }
        }

        private void button_edit_comp_Click(object sender, EventArgs e)
        {
            checkedit();
            if (edit)
            {

                ourComp.EditOurCompany();

                edit = false;
                Close();
            }
            else
            {


            }

        }
    }
}
