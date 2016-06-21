using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fakturyA
{
    public partial class UserControl_PermissionsEditor : UserControl
    {
        private Worker worker;
        public UserControl_PermissionsEditor(string login)
        {
            InitializeComponent();
            userControl_PermissionViewArticles.SetName("Artykuły");
            userControl_PermissionViewCustomer.SetName("Klienci");
            userControl_PermissionViewInvoice.SetName("Faktury");

            worker = new Worker(login);
            labelUser.Text = login + " ("+ worker.Name + " " + worker.SurnName + ")";
            WritePermissions();
        }

        private void WritePermissions()
        {
            userControl_PermissionViewArticles.VisibleSelect(worker.Article_tablePermission.AllowSelect);
            userControl_PermissionViewArticles.VisibleInsert(worker.Article_tablePermission.AllowInsert);
            userControl_PermissionViewArticles.VisibleUpdate(worker.Article_tablePermission.AllowUpdate);
            userControl_PermissionViewArticles.VisibleDelete(worker.Article_tablePermission.AllowDelete);

            userControl_PermissionViewCustomer.VisibleSelect(worker.Customer_tablePermission.AllowSelect);
            userControl_PermissionViewCustomer.VisibleInsert(worker.Customer_tablePermission.AllowInsert);
            userControl_PermissionViewCustomer.VisibleUpdate(worker.Customer_tablePermission.AllowUpdate);
            userControl_PermissionViewCustomer.VisibleDelete(worker.Customer_tablePermission.AllowDelete);

            userControl_PermissionViewInvoice.VisibleSelect(worker.Invoice_tablePermission.AllowSelect);
            userControl_PermissionViewInvoice.VisibleInsert(worker.Invoice_tablePermission.AllowInsert);
            userControl_PermissionViewInvoice.VisibleUpdate(worker.Invoice_tablePermission.AllowUpdate);
            userControl_PermissionViewInvoice.VisibleDelete(worker.Invoice_tablePermission.AllowDelete);

            if (worker.SuperUser)
            {
                pictureBoxSuperUser.Visible = true;
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            FormPermissionEditor w = new FormPermissionEditor(worker, true);
            w.ShowDialog();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Czy na pewno chcesz usunąć użytkownika: " + worker.LoginName + "?", "Potwierdź wybór", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                List<string> queryList = new List<string>();
                queryList.Add(String.Format("DELETE FROM pracownik WHERE mysql_login='{0}'", worker.LoginName));
                queryList.Add(String.Format("DROP USER {0}@{1}", worker.LoginName, DatabaseMySQL.Serwer));
            }
        }


    }
}
