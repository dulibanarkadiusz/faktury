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
        private EditorXML configFile;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private bool ValidateData()
        {
            errorProvider1.Clear();
            if (numericUpDownPortNumbrt.Value == 0)
            {
                errorProvider1.SetError(numericUpDownPortNumbrt, "Podaj port");
                return false;
            }
            else if (textBoxHostname.Text == "")
            {
                errorProvider1.SetError(textBoxHostname, "Należy wypełnić pole");
                return false;
            }
            else if (textBoxDatabaseName.Text == "")
            {
                errorProvider1.SetError(textBoxDatabaseName, "Należy wypełnić pole");
                return false;
            }
            return true;
        }

        private void ReadConfiguration()
        {
            configFile = new EditorXML(MainProgram.NameConfigFile);
            textBoxDatabaseName.Text = configFile.FindInXML("databaseName");
            textBoxHostname.Text = configFile.FindInXML("hostname");
            int port = 0;
            int.TryParse(configFile.FindInXML("port"), out port);
            numericUpDownPortNumbrt.Value = port;
        }

        private void SaveConfiguration()
        {
            configFile.AddToXML("databaseName", textBoxDatabaseName.Text);
            configFile.AddToXML("hostname", textBoxHostname.Text);
            configFile.AddToXML("port", numericUpDownPortNumbrt.Value.ToString());
        }

        private bool IsTheFirstRunning()
        {
            if (configFile.FindInXML("companyname") == "") // and other
            {
                return true;
            }
            return false;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (!ValidateData())
            {
                tabControl1.SelectTab(1);
                return;
            }
            else
            {
                tabControl1.SelectTab(0);
            }


            if (DatabaseMySQL.TryConnect(textBoxLoginname.Text, textBoxPassword.Text, textBoxDatabaseName.Text, textBoxHostname.Text, numericUpDownPortNumbrt.Value.ToString()))
            {
                SaveConfiguration();

                //MainProgram.LoggIn(textBoxLoginname.Text);
                DatabaseMySQL.Uzytkownik = textBoxLoginname.Text;
                DatabaseMySQL.Haslo = textBoxPassword.Text;
                DatabaseMySQL.Port = (uint)(numericUpDownPortNumbrt.Value);
                DatabaseMySQL.Serwer = textBoxHostname.Text;
                DatabaseMySQL.Database = textBoxDatabaseName.Text;

                Worker worker = new Worker(textBoxLoginname.Text);
                MainProgram.LoggIn(worker);

                FormMain w = new FormMain();
                w.Show();
                Hide();
            }
            else
            {
                errorProvider1.SetError(panelFormInputs, "Logowanie nie powiodło się");
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            ReadConfiguration();
        }
    }
}
