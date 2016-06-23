namespace fakturyA
{
    partial class FormInvoicesList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFindNumber = new System.Windows.Forms.TextBox();
            this.textBoxFindCustomerName = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NrFaktury = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KlientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sprzedawca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KlientNIP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WartoscFaktury = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoZaplaty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataWystawienia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TerminPlatnosci = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxMaximumResults = new System.Windows.Forms.ComboBox();
            this.textBoxFindNIP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 10;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxFindNumber, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxFindCustomerName, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 8, 1);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxMaximumResults, 9, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxFindNIP, 6, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 5, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(909, 546);
            this.tableLayoutPanel1.TabIndex = 5;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Numer faktury:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(317, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nazwa";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxFindNumber
            // 
            this.textBoxFindNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFindNumber.Location = new System.Drawing.Point(183, 28);
            this.textBoxFindNumber.Name = "textBoxFindNumber";
            this.textBoxFindNumber.Size = new System.Drawing.Size(84, 20);
            this.textBoxFindNumber.TabIndex = 9;
            this.textBoxFindNumber.TextChanged += new System.EventHandler(this.FindInInvoices);
            // 
            // textBoxFindCustomerName
            // 
            this.textBoxFindCustomerName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFindCustomerName.Location = new System.Drawing.Point(363, 28);
            this.textBoxFindCustomerName.Name = "textBoxFindCustomerName";
            this.textBoxFindCustomerName.Size = new System.Drawing.Size(84, 20);
            this.textBoxFindCustomerName.TabIndex = 10;
            this.textBoxFindCustomerName.TextChanged += new System.EventHandler(this.FindInInvoices);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.index,
            this.NrFaktury,
            this.KlientName,
            this.sprzedawca,
            this.KlientNIP,
            this.WartoscFaktury,
            this.DoZaplaty,
            this.DataWystawienia,
            this.TerminPlatnosci});
            this.tableLayoutPanel1.SetColumnSpan(this.dataGridView1, 10);
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 53);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(903, 490);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.SortCompare += new System.Windows.Forms.DataGridViewSortCompareEventHandler(this.customSortCompare);
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // index
            // 
            this.index.HeaderText = "Column1";
            this.index.Name = "index";
            this.index.ReadOnly = true;
            this.index.Visible = false;
            // 
            // NrFaktury
            // 
            this.NrFaktury.HeaderText = "Numer faktury";
            this.NrFaktury.Name = "NrFaktury";
            this.NrFaktury.ReadOnly = true;
            // 
            // KlientName
            // 
            this.KlientName.HeaderText = "Nazwa klienta";
            this.KlientName.Name = "KlientName";
            this.KlientName.ReadOnly = true;
            this.KlientName.Width = 160;
            // 
            // sprzedawca
            // 
            this.sprzedawca.HeaderText = "Wystawił";
            this.sprzedawca.Name = "sprzedawca";
            this.sprzedawca.ReadOnly = true;
            this.sprzedawca.Width = 130;
            // 
            // KlientNIP
            // 
            this.KlientNIP.HeaderText = "NIP Klienta";
            this.KlientNIP.Name = "KlientNIP";
            this.KlientNIP.ReadOnly = true;
            // 
            // WartoscFaktury
            // 
            this.WartoscFaktury.HeaderText = "Wartość faktury";
            this.WartoscFaktury.Name = "WartoscFaktury";
            this.WartoscFaktury.ReadOnly = true;
            this.WartoscFaktury.Width = 105;
            // 
            // DoZaplaty
            // 
            this.DoZaplaty.HeaderText = "Do zapłaty";
            this.DoZaplaty.Name = "DoZaplaty";
            this.DoZaplaty.ReadOnly = true;
            this.DoZaplaty.Width = 105;
            // 
            // DataWystawienia
            // 
            this.DataWystawienia.HeaderText = "Data wystawienia";
            this.DataWystawienia.Name = "DataWystawienia";
            this.DataWystawienia.ReadOnly = true;
            // 
            // TerminPlatnosci
            // 
            this.TerminPlatnosci.HeaderText = "Termin zapłaty";
            this.TerminPlatnosci.Name = "TerminPlatnosci";
            this.TerminPlatnosci.ReadOnly = true;
            this.TerminPlatnosci.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(730, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Max. wyników:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxMaximumResults
            // 
            this.comboBoxMaximumResults.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMaximumResults.Items.AddRange(new object[] {
            "10",
            "25",
            "50",
            "100",
            "250",
            "500",
            "Wszystko"});
            this.comboBoxMaximumResults.Location = new System.Drawing.Point(813, 28);
            this.comboBoxMaximumResults.Name = "comboBoxMaximumResults";
            this.comboBoxMaximumResults.Size = new System.Drawing.Size(93, 21);
            this.comboBoxMaximumResults.TabIndex = 13;
            // 
            // textBoxFindNIP
            // 
            this.textBoxFindNIP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFindNIP.Location = new System.Drawing.Point(543, 28);
            this.textBoxFindNIP.Name = "textBoxFindNIP";
            this.textBoxFindNIP.Size = new System.Drawing.Size(84, 20);
            this.textBoxFindNIP.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(509, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "NIP:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FormInvoicesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 546);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormInvoicesList";
            this.Text = "Lista wystawionych faktur";
            this.Load += new System.EventHandler(this.FormInvoice_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxFindNumber;
        private System.Windows.Forms.TextBox textBoxFindCustomerName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxMaximumResults;
        private System.Windows.Forms.TextBox textBoxFindNIP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn index;
        private System.Windows.Forms.DataGridViewTextBoxColumn NrFaktury;
        private System.Windows.Forms.DataGridViewTextBoxColumn KlientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn sprzedawca;
        private System.Windows.Forms.DataGridViewTextBoxColumn KlientNIP;
        private System.Windows.Forms.DataGridViewTextBoxColumn WartoscFaktury;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoZaplaty;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataWystawienia;
        private System.Windows.Forms.DataGridViewTextBoxColumn TerminPlatnosci;

    }
}