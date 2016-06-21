using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fakturyA
{
    public class Permission
    {
        public bool AllowSelect { get; private set; }
        public bool AllowInsert { get; private set; }
        public bool AllowUpdate { get; private set; }
        public bool AllowDelete { get; private set; }

        public Permission()
        {
            AllowSelect = false;
            AllowInsert = false;
            AllowUpdate = false;
            AllowDelete = false;
        }

        public void SetPermissions(string dataRow)
        {
            // dataRow example:
            // GRANT SELECT, INSERT, UPDATE ON `faktury`.`faktura` TO 'a_duliban'@'localhost'

            if (dataRow.Contains("SELECT"))
            {
                AllowSelect = true; 
            }
            if (dataRow.Contains("UPDATE"))
            {
                AllowUpdate = true;
            }
            if (dataRow.Contains("INSERT"))
            {
                AllowInsert = true;
            }
            if (dataRow.Contains("DELETE"))
            {
                AllowDelete = true;
            }

        }

        public void SetFullPermission()
        {
            AllowSelect = true;
            AllowInsert = true;
            AllowUpdate = true;
            AllowDelete = true;
        }
    }
}
