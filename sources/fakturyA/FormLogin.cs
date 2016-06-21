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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (DatabaseMySQL.TryConnect(textBoxLoginname.Text, textBoxPassword.Text, textBoxDatabaseName.Text, textBoxHostname.Text, numericUpDownPortNumbrt.Value.ToString()))
            {
                MainProgram.LoggIn(textBoxLoginname.Text);
                DatabaseMySQL.Uzytkownik = textBoxLoginname.Text;
                DatabaseMySQL.Haslo = textBoxPassword.Text;
                DatabaseMySQL.Port = (uint)(numericUpDownPortNumbrt.Value);
                DatabaseMySQL.Serwer = textBoxHostname.Text;
                DatabaseMySQL.Database = textBoxDatabaseName.Text;

                Worker worker = new Worker(textBoxLoginname.Text);
                MainProgram.LoggIn(worker);

                FormMain w = new FormMain();
                w.Show();
                this.Hide();
            }
            else
            {
                errorProvider1.SetError(panelFormInputs, "Logowanie nie powiodło się");
            }
        }
    }
}
