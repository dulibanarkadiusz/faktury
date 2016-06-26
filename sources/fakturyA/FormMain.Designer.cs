namespace fakturyA
{
    partial class FormMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bazaDanychToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eksportujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ustawieniaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uprawnieniaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pokażMojeUprawnieniaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pokażUżytkownikówToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataSet1 = new System.Data.DataSet();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button5 = new System.Windows.Forms.Button();
            this.buttonShowArticles = new System.Windows.Forms.Button();
            this.buttonShowCustomers = new System.Windows.Forms.Button();
            this.buttonNewInvoice = new System.Windows.Forms.Button();
            this.buttonInvoicesList = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.programToolStripMenuItem,
            this.uprawnieniaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1117, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bazaDanychToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // bazaDanychToolStripMenuItem
            // 
            this.bazaDanychToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importujToolStripMenuItem,
            this.eksportujToolStripMenuItem});
            this.bazaDanychToolStripMenuItem.Name = "bazaDanychToolStripMenuItem";
            this.bazaDanychToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.bazaDanychToolStripMenuItem.Text = "Baza danych";
            // 
            // importujToolStripMenuItem
            // 
            this.importujToolStripMenuItem.Name = "importujToolStripMenuItem";
            this.importujToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.importujToolStripMenuItem.Text = "Importuj";
            // 
            // eksportujToolStripMenuItem
            // 
            this.eksportujToolStripMenuItem.Name = "eksportujToolStripMenuItem";
            this.eksportujToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.eksportujToolStripMenuItem.Text = "Eksportuj";
            // 
            // programToolStripMenuItem
            // 
            this.programToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ustawieniaToolStripMenuItem});
            this.programToolStripMenuItem.Name = "programToolStripMenuItem";
            this.programToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.programToolStripMenuItem.Text = "Program";
            // 
            // ustawieniaToolStripMenuItem
            // 
            this.ustawieniaToolStripMenuItem.Name = "ustawieniaToolStripMenuItem";
            this.ustawieniaToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.ustawieniaToolStripMenuItem.Text = "Ustawienia";
            // 
            // uprawnieniaToolStripMenuItem
            // 
            this.uprawnieniaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pokażMojeUprawnieniaToolStripMenuItem,
            this.pokażUżytkownikówToolStripMenuItem});
            this.uprawnieniaToolStripMenuItem.Name = "uprawnieniaToolStripMenuItem";
            this.uprawnieniaToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.uprawnieniaToolStripMenuItem.Text = "Pracownicy";
            // 
            // pokażMojeUprawnieniaToolStripMenuItem
            // 
            this.pokażMojeUprawnieniaToolStripMenuItem.Name = "pokażMojeUprawnieniaToolStripMenuItem";
            this.pokażMojeUprawnieniaToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.pokażMojeUprawnieniaToolStripMenuItem.Text = "Pokaż moje uprawnienia";
            this.pokażMojeUprawnieniaToolStripMenuItem.Click += new System.EventHandler(this.pokażMojeUprawnieniaToolStripMenuItem_Click);
            // 
            // pokażUżytkownikówToolStripMenuItem
            // 
            this.pokażUżytkownikówToolStripMenuItem.Name = "pokażUżytkownikówToolStripMenuItem";
            this.pokażUżytkownikówToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.pokażUżytkownikówToolStripMenuItem.Text = "Pokaż użytkowników";
            this.pokażUżytkownikówToolStripMenuItem.Click += new System.EventHandler(this.pokażUżytkownikówToolStripMenuItem_Click);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
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
            this.tableLayoutPanel1.Controls.Add(this.button5, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonShowArticles, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonShowCustomers, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonNewInvoice, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonInvoicesList, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1117, 71);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button5.Location = new System.Drawing.Point(447, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(105, 65);
            this.button5.TabIndex = 12;
            this.button5.Text = "Informacje o firmie";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // buttonShowArticles
            // 
            this.buttonShowArticles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonShowArticles.Location = new System.Drawing.Point(336, 3);
            this.buttonShowArticles.Name = "buttonShowArticles";
            this.buttonShowArticles.Size = new System.Drawing.Size(105, 65);
            this.buttonShowArticles.TabIndex = 7;
            this.buttonShowArticles.Text = "Towary i usługi";
            this.buttonShowArticles.UseVisualStyleBackColor = true;
            this.buttonShowArticles.Click += new System.EventHandler(this.buttonTowaryUslugi_Click);
            // 
            // buttonShowCustomers
            // 
            this.buttonShowCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonShowCustomers.Location = new System.Drawing.Point(225, 3);
            this.buttonShowCustomers.Name = "buttonShowCustomers";
            this.buttonShowCustomers.Size = new System.Drawing.Size(105, 65);
            this.buttonShowCustomers.TabIndex = 6;
            this.buttonShowCustomers.Text = "Kontrahenci";
            this.buttonShowCustomers.UseVisualStyleBackColor = true;
            this.buttonShowCustomers.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonNewInvoice
            // 
            this.buttonNewInvoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonNewInvoice.Location = new System.Drawing.Point(114, 3);
            this.buttonNewInvoice.Name = "buttonNewInvoice";
            this.buttonNewInvoice.Size = new System.Drawing.Size(105, 65);
            this.buttonNewInvoice.TabIndex = 5;
            this.buttonNewInvoice.Text = "Nowa faktura";
            this.buttonNewInvoice.UseVisualStyleBackColor = true;
            this.buttonNewInvoice.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonInvoicesList
            // 
            this.buttonInvoicesList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonInvoicesList.Location = new System.Drawing.Point(3, 3);
            this.buttonInvoicesList.Name = "buttonInvoicesList";
            this.buttonInvoicesList.Size = new System.Drawing.Size(105, 65);
            this.buttonInvoicesList.TabIndex = 4;
            this.buttonInvoicesList.Text = "Lista faktur VAT";
            this.buttonInvoicesList.UseVisualStyleBackColor = true;
            this.buttonInvoicesList.Click += new System.EventHandler(this.buttonInvoicesList_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 715);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Fakturka";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programToolStripMenuItem;
        private System.Data.DataSet dataSet1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonShowArticles;
        private System.Windows.Forms.Button buttonShowCustomers;
        private System.Windows.Forms.Button buttonNewInvoice;
        private System.Windows.Forms.Button buttonInvoicesList;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ToolStripMenuItem bazaDanychToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importujToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eksportujToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ustawieniaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uprawnieniaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pokażMojeUprawnieniaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pokażUżytkownikówToolStripMenuItem;
    }
}

