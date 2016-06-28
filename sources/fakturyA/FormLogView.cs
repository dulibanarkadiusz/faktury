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
    public partial class FormLogView : Form
    {
        public static List<string[]> changeHistory { get; set; }
        public FormLogView()
        {
            InitializeComponent();
            changeHistory = new List<string[]>();
        }
        private void GetAllRecords()
        {
            dataGridView1.Rows.Clear();
            DatabaseMySQL.LoadLogView();
            int i = 0;
            foreach (string[] a in changeHistory)
            {
                dataGridView1.Rows.Add();
                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[i];
                row.Cells["Kto"].Value = a[0];
                row.Cells["co_zrobil"].Value = a[1];
                row.Cells["ktora_tabela"].Value = a[2];
                row.Cells["przed_zmiana"].Value = a[3];
                row.Cells["Po_zmianie"].Value = a[4];
                row.Cells["kiedy"].Value = a[5];
                i++;

            }

        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();

            }
        }

        private void FormLogView_Load(object sender, EventArgs e)
        {

            GetAllRecords();

        }
        private void FindInLogs(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            var resultsArticles = from string[] a in changeHistory
                                  where (changeHistory[0].Contains(who_tb.Text))
                                     select a;
            int i = 0;
            foreach (string[] a in resultsArticles)
            {
                i = dataGridView1.Rows.Add();

                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[i];
                row.Cells["kto"].Value = a[0];
                row.Cells["co_zrobil"].Value = a[1];
                row.Cells["ktora_tabela"].Value = a[2];
                row.Cells["przed_zmiana"].Value = a[3];
                row.Cells["po_zmianie"].Value = a[4];
                row.Cells["kiedy"].Value = a[5];
                i++;

            }
        }
    }
}
