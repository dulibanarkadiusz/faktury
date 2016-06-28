using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fakturyA
{
    public class Worker
    {
        public string LoginName { get; private set; }
        public int ID { get; private set; }
        public string Name { get; private set; }
        public string SurnName { get; private set; }
        public bool SuperUser { get; private set; }

        public Permission Article_tablePermission { get; private set; }
        public Permission Invoice_tablePermission { get; private set; }
        public Permission Customer_tablePermission { get; private set; }
        
        public Worker(string login)
        {
            LoginName = login;
            List<string> data = DatabaseMySQL.GetUserPermissions(login);
            string[] userData = DatabaseMySQL.GetUserIDandName(login);

            ID = int.Parse(userData[0]);
            Name = userData[1];
            SurnName = userData[2];
            SuperUser = false;

            Article_tablePermission = new Permission();
            Customer_tablePermission = new Permission();
            Invoice_tablePermission = new Permission();

            foreach (string s in data)
            {
                if (s.Contains(MainProgram.ArticlesTablename))
                {
                    Article_tablePermission.SetPermissions(s);
                }
                else if (s.Contains(MainProgram.CustomersTablename))
                {
                    Customer_tablePermission.SetPermissions(s);
                }
                else if (s.Contains(MainProgram.InvoicesTablename))
                {
                    Invoice_tablePermission.SetPermissions(s);
                }
                else if (s.Contains("ALL PRIVILEGES"))
                {
                    SuperUser = true;
                    Article_tablePermission.SetFullPermission();
                    Customer_tablePermission.SetFullPermission();
                    Invoice_tablePermission.SetFullPermission();
                }
            }
        }
        
    }
}
