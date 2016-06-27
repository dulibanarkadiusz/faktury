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
                MainProgram.CreateArticleWindow(this);
            }          
            MainProgram.ArticlesWindow.Show();
            MainProgram.ArticlesWindow.EditMode = true;
        }

        private void buttonInvoicesList_Click(object sender, EventArgs e)
        {
            if (MainProgram.InvoiceWindow == null)
            {
                MainProgram.CreateInvoiceListWindow(this);
            }
            
            MainProgram.InvoiceWindow.Show();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainProgram.InvoiceEditor = new FormInvoiceEditor();
            MainProgram.InvoiceEditor.ShowDialog();
        }

        private void pokażMojeUprawnieniaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPermissionEditor w = new FormPermissionEditor(MainProgram.Worker, false, null);
            w.ShowDialog();
        }

        private void pokażUżytkownikówToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUserList w = new FormUserList();
            w.ShowDialog();
        }

        private void buttonShowCustomers_Click(object sender, EventArgs e)
        {
            if (MainProgram.CustomerWindow == null)
            {
                MainProgram.CreateCustomersListWindow(this);
            }
            
            MainProgram.CustomerWindow.Show();

        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            if (MainProgram.Worker.Invoice_tablePermission.AllowSelect == false)
            {
                buttonInvoicesList.Enabled = false;
            }
            if (MainProgram.Worker.Invoice_tablePermission.AllowInsert == false)
            {
                buttonNewInvoice.Enabled = false;
            }
            if (MainProgram.Worker.Customer_tablePermission.AllowSelect == false)
            {
                buttonShowCustomers.Enabled = false;
            }
            if (MainProgram.Worker.Invoice_tablePermission.AllowSelect == false)
            {
                buttonShowArticles.Enabled = false;
            }

            // menu 
            if (MainProgram.Worker.SuperUser == false)
            {
                pokażUżytkownikówToolStripMenuItem.Visible = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (MainProgram.OurCompanyWindow == null)
            {
                MainProgram.CreateOurCompanyDataWindow(this);
            }

            MainProgram.OurCompanyWindow.Show();
        }
    }
}
