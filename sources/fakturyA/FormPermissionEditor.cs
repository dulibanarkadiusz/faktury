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
    public partial class FormPermissionEditor : Form
    {
        private Worker worker;
        private bool isLoad = false;
        private FormUserList formUserList;

        public FormPermissionEditor(Worker worker, bool editMode, FormUserList form)
        {
            InitializeComponent();
            this.worker = worker;
            if (!editMode)
            {
                DisableEdit();
                buttonSave.Visible = false;
                checkBoxSuperUser.Visible = false;
            }

            formUserList = form;
        }

        private void FormMyPermissionView_Load(object sender, EventArgs e)
        {
            checkBoxArticleSelect.Checked = worker.Article_tablePermission.AllowSelect;
            checkBoxArticleInsert.Checked = worker.Article_tablePermission.AllowInsert;
            checkBoxArticleUpdate.Checked = worker.Article_tablePermission.AllowUpdate;
            checkBoxArticleDelete.Checked = worker.Article_tablePermission.AllowDelete;

            checkBoxInvoiceSelect.Checked = worker.Invoice_tablePermission.AllowSelect;
            checkBoxInvoiceInsert.Checked = worker.Invoice_tablePermission.AllowInsert;
            checkBoxInvoiceUpdate.Checked = worker.Invoice_tablePermission.AllowUpdate;
            checkBoxInvoiceDelete.Checked = worker.Invoice_tablePermission.AllowDelete;

            checkBoxCustomerSelect.Checked = worker.Customer_tablePermission.AllowSelect;
            checkBoxCustomerInsert.Checked = worker.Customer_tablePermission.AllowInsert;
            checkBoxCustomerUpdate.Checked = worker.Customer_tablePermission.AllowUpdate;
            checkBoxCustomerDelete.Checked = worker.Customer_tablePermission.AllowDelete;

            checkBoxSuperUser.Checked = worker.SuperUser;
            isLoad = true;
        }

        private void DisableEdit()
        {
            tableLayoutPanel1.Enabled = false;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (checkBoxSuperUser.Checked == false)
            {
                List<string> queryList = new List<string>();
                queryList.Add(String.Format("REVOKE ALL PRIVILEGES ON * . * FROM {0}@{1};", worker.LoginName, DatabaseMySQL.Serwer));

                string articles_Permissions = "";
                if (checkBoxArticleInsert.Checked) articles_Permissions += "INSERT, ";
                if (checkBoxArticleSelect.Checked) articles_Permissions += "SELECT, ";
                if (checkBoxArticleUpdate.Checked) articles_Permissions += "UPDATE, ";
                if (checkBoxArticleDelete.Checked) articles_Permissions += "DELETE, ";

                string invoices_Permissions = "";
                if (checkBoxInvoiceInsert.Checked) invoices_Permissions += "INSERT, ";
                if (checkBoxInvoiceSelect.Checked) invoices_Permissions += "SELECT, ";
                if (checkBoxInvoiceUpdate.Checked) invoices_Permissions += "UPDATE, ";
                if (checkBoxInvoiceDelete.Checked) invoices_Permissions += "DELETE, ";

                string customers_Permissions = "";
                if (checkBoxCustomerInsert.Checked) customers_Permissions += "INSERT, ";
                if (checkBoxCustomerSelect.Checked) customers_Permissions += "SELECT, ";
                if (checkBoxCustomerUpdate.Checked) customers_Permissions += "UPDATE, ";
                if (checkBoxCustomerDelete.Checked) customers_Permissions += "DELETE, ";


                if (worker.Article_tablePermission.AllowDelete || worker.Article_tablePermission.AllowInsert || worker.Article_tablePermission.AllowSelect || worker.Article_tablePermission.AllowUpdate)
                {
                    queryList.Add(String.Format("REVOKE ALL PRIVILEGES ON {0}.{1} FROM {2}@{3};", DatabaseMySQL.Database, MainProgram.ArticlesTablename, worker.LoginName, DatabaseMySQL.Serwer));
                }
                if (articles_Permissions.Length > 0)
                {
                    articles_Permissions = articles_Permissions.Remove(articles_Permissions.Length - 2);

                    queryList.Add(String.Format("GRANT {0} ON {1}.{2} TO {3}@{4};", articles_Permissions, DatabaseMySQL.Database, MainProgram.ArticlesTablename, worker.LoginName, DatabaseMySQL.Serwer));
                }


                if (worker.Invoice_tablePermission.AllowDelete || worker.Invoice_tablePermission.AllowInsert || worker.Invoice_tablePermission.AllowSelect || worker.Invoice_tablePermission.AllowUpdate)
                {
                    queryList.Add(String.Format("REVOKE ALL PRIVILEGES ON {0}.{1} FROM {2}@{3};", DatabaseMySQL.Database, MainProgram.InvoicesTablename, worker.LoginName, DatabaseMySQL.Serwer));
                }
                if (invoices_Permissions.Length > 0)
                {
                    invoices_Permissions = invoices_Permissions.Remove(invoices_Permissions.Length - 2);
                    queryList.Add(String.Format("GRANT {0} ON {1}.{2} TO {3}@{4};", invoices_Permissions, DatabaseMySQL.Database, MainProgram.InvoicesTablename, worker.LoginName, DatabaseMySQL.Serwer));
                }



                if (worker.Customer_tablePermission.AllowDelete || worker.Customer_tablePermission.AllowInsert || worker.Customer_tablePermission.AllowSelect || worker.Customer_tablePermission.AllowUpdate)
                {
                    queryList.Add(String.Format("REVOKE ALL PRIVILEGES ON {0}.{1} FROM {2}@{3};", DatabaseMySQL.Database, MainProgram.CustomersTablename, worker.LoginName, DatabaseMySQL.Serwer));
                }
                if (customers_Permissions.Length > 0)
                {
                    customers_Permissions = customers_Permissions.Remove(customers_Permissions.Length - 2);
                    queryList.Add(String.Format("GRANT {0} ON {1}.{2} TO {3}@{4};", customers_Permissions, DatabaseMySQL.Database, MainProgram.CustomersTablename, worker.LoginName, DatabaseMySQL.Serwer));
                }

                DatabaseMySQL.ExecuteTransaction(queryList);
            }
            else
            {
                string myQuery = String.Format("GRANT ALL PRIVILEGES ON * . * TO {0}@{1} ", worker.LoginName, DatabaseMySQL.Serwer);
                DatabaseMySQL.ExecuteQuery(myQuery);
            }

            this.Close();
        }

        private void checkBoxInvoice_CheckedChanged(object sender, EventArgs e)
        {
            if ((checkBoxArticleSelect.Checked == false || checkBoxCustomerSelect.Checked == false) && isLoad)
            {
                checkBoxArticleSelect.Checked = true;
                checkBoxCustomerSelect.Checked = true;
                MessageBox.Show("Odczytywanie, zapisywanie oraz aktualizowanie faktur wymaga uprawnienia wyświetlania (select) dla kontrahentów i artykułów.\n\nDokonano odpowiedniej korekty.", "Wprowadzono korektę", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void checkBoxSELECT_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked == false && isLoad && (checkBoxInvoiceInsert.Checked == true || checkBoxInvoiceSelect.Checked == true || checkBoxInvoiceUpdate.Checked == true))
            {
                ((CheckBox)sender).Checked = true;
                MessageBox.Show("Nie można odebrać prawa odczytu dla artykułów i kontrahentów, ponieważ są one niezbędne do:\n- wyświetlania faktur\n- tworzenia faktur\n- edytowania faktur\n\nPrzed dokonaniem zmian należy najpiere odebrać odpowiednie prawa związane z zarządzaniem fakturami.", "Operacja niedozwolona", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBoxSuperUser_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked == true)
            {
                tableLayoutPanel1.Enabled = false;
                checkBoxSuperUser.Enabled = true;
                foreach (object o in this.Controls)
                {
                    if (o is CheckBox)
                    {
                        ((CheckBox)o).Checked = true;
                    }
                }
            }
            else
            {
                tableLayoutPanel1.Enabled = true;
            }
        }
    }
}
