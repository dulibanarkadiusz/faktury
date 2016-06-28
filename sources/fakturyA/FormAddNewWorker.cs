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
    public partial class FormAddNewWorker : Form
    {
        List<string> listaZapytan = new List<string>();
        bool isSecurity = false;
        public FormAddNewWorker()
        {
            InitializeComponent();
        }
        private void Security()
        {
            bool empty_login = String.IsNullOrEmpty(BoxLogin.Text);
            bool empty_pass = String.IsNullOrEmpty(BoxPassword.Text);
            bool empty_name = String.IsNullOrEmpty(BoxName.Text);
            bool empty_last_name = String.IsNullOrEmpty(BoxLastName.Text);
            bool empty_2pass = String.IsNullOrEmpty(Box2Pass.Text);
            if (empty_login == true)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(label1, "wypełnij wymagane dane");
            }
            else if (empty_pass == true)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(label2, "wypełnij wymagane dane");
            }
            else if (empty_name == true)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(label3, "wypełnij wymagane dane");
            }
            else if (empty_last_name == true)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(label4, "wypełnij wymagane dane");
            }
            else if (empty_2pass == true)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(label5, "wypełnij wymagane dane");
            }
            else if (Box2Pass.Text != BoxPassword.Text)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(label5, "Hasła nie sa takie same");
            }
            else
            {
                errorProvider1.Clear();
                isSecurity = true;
            }

        }
        private void clearTextBox()
        {
            BoxLogin.Clear();
            BoxLastName.Clear();
            Box2Pass.Clear();
            BoxPassword.Clear();
            BoxName.Clear();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string[] s = { BoxName.Text, BoxLastName.Text, BoxLogin.Text };
            if (isSecurity == false)
                Security();
            else
            {
                dodaj();
                DatabaseMySQL.ExecuteTransaction(listaZapytan);
                clearTextBox();
                this.Close();
            }

        }
        private void dodaj()
        {
            string query = String.Format("INSERT INTO pracownik SET imie='{0}', nazwisko='{1}', mysql_login='{2}'", BoxName.Text, BoxLastName.Text, BoxLogin.Text);
            listaZapytan.Add(query);
            string query2 = String.Format("CREATE USER login='{0}'@'1' IDENTIFIED BY pass='{2}'", BoxLogin.Text, new EditorXML(MainProgram.NameConfigFile).FindInXML("hostname"), BoxPassword.Text);
            listaZapytan.Add(query2);
        }
    }
}
