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
    public partial class FormUserList : Form
    {
        List<UserControl_PermissionsEditor> componentsList = new List<UserControl_PermissionsEditor>();
        List<string> UsersNicknames = new List<string>();
        public FormUserList()
        {
            InitializeComponent();
            LoadContent();
        }

        public void LoadContent()
        {
            UsersNicknames.Clear();
            componentsList.Clear();
            UsersNicknames = DatabaseMySQL.GetUsersNicknamesList();
            panel1.Controls.Clear();
            int posY = 0; int i = 0;
            for (int j = 0; j < 3; j++)
                foreach (string nickname in UsersNicknames)
                {
                    componentsList.Add(new UserControl_PermissionsEditor(nickname, this));

                    componentsList[i].Location = new Point(0, posY);
                    panel1.Controls.Add(componentsList[i++]);

                    posY += componentsList[0].Height + 5;
                }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
