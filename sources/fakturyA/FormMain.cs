using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace fakturyA
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            MainProgram.DatabaseName = "faktury";

            MainProgram.InvoiceObjectsList = new List<Invoice>();
            FormArticles.articlesList = new List<Article>();
            MainProgram.CustomersList = new List<Customers>();
        }

        private void buttonTowaryUslugi_Click(object sender, EventArgs e)
        {
            if (MainProgram.ArticlesWindow == null)
            {
                MainProgram.ArticlesWindow = new FormArticles();
                MainProgram.ArticlesWindow.MdiParent = this;
                MainProgram.ArticlesWindow.Show();
            }
            else
            {
                MainProgram.ArticlesWindow.Show();
            }
            MainProgram.ArticlesWindow.EditMode = true;
        }

        private void buttonInvoicesList_Click(object sender, EventArgs e)
        {
            if (MainProgram.InvoiceWindow == null)
            {
                MainProgram.InvoiceWindow = new FormInvoicesList();
                MainProgram.InvoiceWindow.MdiParent = this;
                MainProgram.InvoiceWindow.Show();
            }
            else
            {
                MainProgram.InvoiceWindow.Show();
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainProgram.InvoiceEditor = new FormInvoiceEditor();
            MainProgram.InvoiceEditor.ShowDialog();
        }

        private void pokażMojeUprawnieniaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPermissionEditor w = new FormPermissionEditor(MainProgram.Worker, false);
            w.ShowDialog();
        }

        private void pokażUżytkownikówToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUserList w = new FormUserList();
            w.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                if (MainProgram.CustomerWindow == null)
                {
                    MainProgram.CustomerWindow = new FormCustomers();
                    MainProgram.CustomerWindow.MdiParent = this;
                    MainProgram.CustomerWindow.Show();
                }
                else
                {
                    MainProgram.CustomerWindow.Show();
                }

            }
        }
    }
}
