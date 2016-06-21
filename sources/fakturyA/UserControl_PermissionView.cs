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
    public partial class UserControl_PermissionView : UserControl
    {
        public UserControl_PermissionView()
        {
            InitializeComponent();
        }

        public void SetName(string name)
        {
            groupBox1.Text = name;
        }

        public void VisibleSelect(bool isVisible)
        {
            pictureBoxSelect.Visible = isVisible;
        }

        public void VisibleInsert(bool isVisible)
        {
            pictureBoxInsert.Visible = isVisible;
        }

        public void VisibleUpdate(bool isVisible)
        {
            pictureBoxUpdate.Visible = isVisible;
        }

        public void VisibleDelete(bool isVisible)
        {
            pictureBoxDelete.Visible = isVisible;
        }
    }
}
