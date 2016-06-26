namespace fakturyA
{
    partial class FormInvoiceEditor
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.comboBoxPayMethod = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.comboBoxSelectPaymentDate = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerDatePayment = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerDateInvoice = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerDateSale = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxInvoiceNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonChooseCustomer = new System.Windows.Forms.Button();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.labelCustomerAdress = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.labelCustomerNIP = new System.Windows.Forms.Label();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.labelCustomerName = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceNetto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price_brutto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.measureUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueNetto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueBrutto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonSaveInvoice = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonAddArticleToInvoice = new System.Windows.Forms.Button();
            this.buttonRemoveArticleFromInvoice = new System.Windows.Forms.Button();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.labelInvoiceTotalNetto = new System.Windows.Forms.Label();
            this.labelInvoiceValue = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxAmountPaid = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.buttonEditArticleOnInvoice = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.comboBoxPayMethod, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(23, 30);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(213, 28);
            this.tableLayoutPanel5.TabIndex = 6;
            // 
            // comboBoxPayMethod
            // 
            this.comboBoxPayMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPayMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxPayMethod.FormattingEnabled = true;
            this.comboBoxPayMethod.Items.AddRange(new object[] {
            "przelew",
            "gotówka",
            "karta płatnicza",
            "płatność online",
            "płatność ratalna"});
            this.comboBoxPayMethod.Location = new System.Drawing.Point(109, 3);
            this.comboBoxPayMethod.Name = "comboBoxPayMethod";
            this.comboBoxPayMethod.Size = new System.Drawing.Size(101, 21);
            this.comboBoxPayMethod.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(19, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Sposób zapłaty:";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 121F));
            this.tableLayoutPanel4.Controls.Add(this.comboBoxSelectPaymentDate, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.dateTimePickerDatePayment, 2, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(298, 30);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(337, 28);
            this.tableLayoutPanel4.TabIndex = 4;
            // 
            // comboBoxSelectPaymentDate
            // 
            this.comboBoxSelectPaymentDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSelectPaymentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxSelectPaymentDate.FormattingEnabled = true;
            this.comboBoxSelectPaymentDate.Items.AddRange(new object[] {
            "7 dni",
            "14 dni",
            "Wybierz inny"});
            this.comboBoxSelectPaymentDate.Location = new System.Drawing.Point(111, 3);
            this.comboBoxSelectPaymentDate.Name = "comboBoxSelectPaymentDate";
            this.comboBoxSelectPaymentDate.Size = new System.Drawing.Size(101, 21);
            this.comboBoxSelectPaymentDate.TabIndex = 6;
            this.comboBoxSelectPaymentDate.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(16, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Termin płatności:";
            // 
            // dateTimePickerDatePayment
            // 
            this.dateTimePickerDatePayment.Enabled = false;
            this.dateTimePickerDatePayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePickerDatePayment.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDatePayment.Location = new System.Drawing.Point(219, 3);
            this.dateTimePickerDatePayment.Name = "dateTimePickerDatePayment";
            this.dateTimePickerDatePayment.Size = new System.Drawing.Size(101, 20);
            this.dateTimePickerDatePayment.TabIndex = 2;
            this.dateTimePickerDatePayment.ValueChanged += new System.EventHandler(this.dateTimePickerDatePayment_ValueChanged);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.dateTimePickerDateInvoice, 1, 0);
            this.tableLayoutPanel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tableLayoutPanel3.Location = new System.Drawing.Point(12, 66);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(213, 28);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(10, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Data wystawienia:";
            // 
            // dateTimePickerDateInvoice
            // 
            this.dateTimePickerDateInvoice.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDateInvoice.Location = new System.Drawing.Point(109, 3);
            this.dateTimePickerDateInvoice.Name = "dateTimePickerDateInvoice";
            this.dateTimePickerDateInvoice.Size = new System.Drawing.Size(101, 20);
            this.dateTimePickerDateInvoice.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.dateTimePickerDateSale, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 94);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(213, 28);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(20, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data sprzedaży:";
            // 
            // dateTimePickerDateSale
            // 
            this.dateTimePickerDateSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePickerDateSale.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDateSale.Location = new System.Drawing.Point(109, 3);
            this.dateTimePickerDateSale.Name = "dateTimePickerDateSale";
            this.dateTimePickerDateSale.Size = new System.Drawing.Size(101, 20);
            this.dateTimePickerDateSale.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.textBoxInvoiceNumber, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(213, 26);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // textBoxInvoiceNumber
            // 
            this.textBoxInvoiceNumber.Enabled = false;
            this.textBoxInvoiceNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxInvoiceNumber.Location = new System.Drawing.Point(109, 3);
            this.textBoxInvoiceNumber.Name = "textBoxInvoiceNumber";
            this.textBoxInvoiceNumber.Size = new System.Drawing.Size(100, 20);
            this.textBoxInvoiceNumber.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(13, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numer faktury:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(258, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(428, 133);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kontrahent";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonChooseCustomer);
            this.panel2.Controls.Add(this.tableLayoutPanel8);
            this.panel2.Controls.Add(this.tableLayoutPanel7);
            this.panel2.Controls.Add(this.tableLayoutPanel6);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.panel2.Location = new System.Drawing.Point(6, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(416, 110);
            this.panel2.TabIndex = 4;
            // 
            // buttonChooseCustomer
            // 
            this.buttonChooseCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonChooseCustomer.Location = new System.Drawing.Point(323, 0);
            this.buttonChooseCustomer.Name = "buttonChooseCustomer";
            this.buttonChooseCustomer.Size = new System.Drawing.Size(90, 22);
            this.buttonChooseCustomer.TabIndex = 0;
            this.buttonChooseCustomer.Text = "Wybierz z listy";
            this.buttonChooseCustomer.UseVisualStyleBackColor = true;
            this.buttonChooseCustomer.Click += new System.EventHandler(this.buttonChooseCustomer_Click);
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 2;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.82178F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.17822F));
            this.tableLayoutPanel8.Controls.Add(this.labelCustomerAdress, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel8.Location = new System.Drawing.Point(3, 63);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(371, 36);
            this.tableLayoutPanel8.TabIndex = 9;
            // 
            // labelCustomerAdress
            // 
            this.labelCustomerAdress.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelCustomerAdress.AutoSize = true;
            this.labelCustomerAdress.Location = new System.Drawing.Point(69, 11);
            this.labelCustomerAdress.Name = "labelCustomerAdress";
            this.labelCustomerAdress.Size = new System.Drawing.Size(10, 13);
            this.labelCustomerAdress.TabIndex = 3;
            this.labelCustomerAdress.Text = "-";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "adres:";
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.82178F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.17822F));
            this.tableLayoutPanel7.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.labelCustomerNIP, 1, 0);
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 7);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(371, 28);
            this.tableLayoutPanel7.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "NIP:";
            // 
            // labelCustomerNIP
            // 
            this.labelCustomerNIP.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelCustomerNIP.AutoSize = true;
            this.labelCustomerNIP.Location = new System.Drawing.Point(69, 7);
            this.labelCustomerNIP.Name = "labelCustomerNIP";
            this.labelCustomerNIP.Size = new System.Drawing.Size(10, 13);
            this.labelCustomerNIP.TabIndex = 2;
            this.labelCustomerNIP.Text = "-";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.82178F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.17822F));
            this.tableLayoutPanel6.Controls.Add(this.labelCustomerName, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 35);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(371, 28);
            this.tableLayoutPanel6.TabIndex = 7;
            // 
            // labelCustomerName
            // 
            this.labelCustomerName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelCustomerName.AutoSize = true;
            this.labelCustomerName.Location = new System.Drawing.Point(69, 7);
            this.labelCustomerName.Name = "labelCustomerName";
            this.labelCustomerName.Size = new System.Drawing.Size(10, 13);
            this.labelCustomerName.TabIndex = 3;
            this.labelCustomerName.Text = "-";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "nazwa:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nr,
            this.name,
            this.priceNetto,
            this.vat,
            this.price_brutto,
            this.discount,
            this.amount,
            this.measureUnit,
            this.valueNetto,
            this.valueBrutto});
            this.dataGridView1.Location = new System.Drawing.Point(12, 236);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(674, 264);
            this.dataGridView1.TabIndex = 1;
            // 
            // nr
            // 
            this.nr.HeaderText = "Kod";
            this.nr.Name = "nr";
            this.nr.ReadOnly = true;
            this.nr.Width = 40;
            // 
            // name
            // 
            this.name.HeaderText = "Nazwa produktu";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // priceNetto
            // 
            this.priceNetto.HeaderText = "Cena netto";
            this.priceNetto.Name = "priceNetto";
            this.priceNetto.ReadOnly = true;
            // 
            // vat
            // 
            this.vat.HeaderText = "VAT";
            this.vat.Name = "vat";
            this.vat.ReadOnly = true;
            this.vat.Width = 35;
            // 
            // price_brutto
            // 
            this.price_brutto.HeaderText = "Cena brutto";
            this.price_brutto.Name = "price_brutto";
            this.price_brutto.ReadOnly = true;
            // 
            // discount
            // 
            this.discount.HeaderText = "Rabat";
            this.discount.Name = "discount";
            this.discount.ReadOnly = true;
            this.discount.Width = 45;
            // 
            // amount
            // 
            this.amount.HeaderText = "Ilość";
            this.amount.Name = "amount";
            this.amount.ReadOnly = true;
            this.amount.Width = 50;
            // 
            // measureUnit
            // 
            this.measureUnit.HeaderText = "j. m.";
            this.measureUnit.Name = "measureUnit";
            this.measureUnit.ReadOnly = true;
            this.measureUnit.Width = 40;
            // 
            // valueNetto
            // 
            this.valueNetto.HeaderText = "Wartość netto";
            this.valueNetto.Name = "valueNetto";
            this.valueNetto.ReadOnly = true;
            this.valueNetto.Width = 80;
            // 
            // valueBrutto
            // 
            this.valueBrutto.HeaderText = "Wartość brutto";
            this.valueBrutto.Name = "valueBrutto";
            this.valueBrutto.ReadOnly = true;
            this.valueBrutto.Width = 80;
            // 
            // buttonSaveInvoice
            // 
            this.buttonSaveInvoice.Location = new System.Drawing.Point(593, 584);
            this.buttonSaveInvoice.Name = "buttonSaveInvoice";
            this.buttonSaveInvoice.Size = new System.Drawing.Size(93, 33);
            this.buttonSaveInvoice.TabIndex = 2;
            this.buttonSaveInvoice.Text = "Zapisz";
            this.buttonSaveInvoice.UseVisualStyleBackColor = true;
            this.buttonSaveInvoice.Click += new System.EventHandler(this.ButtonSaveInvoice_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel5);
            this.groupBox2.Controls.Add(this.tableLayoutPanel4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.Location = new System.Drawing.Point(12, 161);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(674, 69);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informacje o płatności";
            // 
            // buttonAddArticleToInvoice
            // 
            this.buttonAddArticleToInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAddArticleToInvoice.Location = new System.Drawing.Point(13, 505);
            this.buttonAddArticleToInvoice.Name = "buttonAddArticleToInvoice";
            this.buttonAddArticleToInvoice.Size = new System.Drawing.Size(90, 31);
            this.buttonAddArticleToInvoice.TabIndex = 5;
            this.buttonAddArticleToInvoice.Text = "Dodaj artykuł";
            this.buttonAddArticleToInvoice.UseVisualStyleBackColor = true;
            this.buttonAddArticleToInvoice.Click += new System.EventHandler(this.buttonAddArticleToInvoice_Click);
            // 
            // buttonRemoveArticleFromInvoice
            // 
            this.buttonRemoveArticleFromInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonRemoveArticleFromInvoice.Location = new System.Drawing.Point(109, 506);
            this.buttonRemoveArticleFromInvoice.Name = "buttonRemoveArticleFromInvoice";
            this.buttonRemoveArticleFromInvoice.Size = new System.Drawing.Size(90, 30);
            this.buttonRemoveArticleFromInvoice.TabIndex = 6;
            this.buttonRemoveArticleFromInvoice.Text = "Usuń artykuł";
            this.buttonRemoveArticleFromInvoice.UseVisualStyleBackColor = true;
            this.buttonRemoveArticleFromInvoice.Click += new System.EventHandler(this.buttonRemoveArticleFromInvoice_Click);
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 2;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.25532F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.74468F));
            this.tableLayoutPanel9.Controls.Add(this.labelInvoiceTotalNetto, 1, 1);
            this.tableLayoutPanel9.Controls.Add(this.labelInvoiceValue, 1, 0);
            this.tableLayoutPanel9.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.label11, 0, 2);
            this.tableLayoutPanel9.Controls.Add(this.textBoxAmountPaid, 1, 2);
            this.tableLayoutPanel9.Controls.Add(this.label12, 0, 1);
            this.tableLayoutPanel9.Location = new System.Drawing.Point(329, 506);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 3;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(357, 72);
            this.tableLayoutPanel9.TabIndex = 7;
            // 
            // labelInvoiceTotalNetto
            // 
            this.labelInvoiceTotalNetto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelInvoiceTotalNetto.AutoSize = true;
            this.labelInvoiceTotalNetto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelInvoiceTotalNetto.Location = new System.Drawing.Point(196, 27);
            this.labelInvoiceTotalNetto.Name = "labelInvoiceTotalNetto";
            this.labelInvoiceTotalNetto.Size = new System.Drawing.Size(43, 15);
            this.labelInvoiceTotalNetto.TabIndex = 5;
            this.labelInvoiceTotalNetto.Text = "0,00 zł";
            this.labelInvoiceTotalNetto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelInvoiceValue
            // 
            this.labelInvoiceValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelInvoiceValue.AutoSize = true;
            this.labelInvoiceValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelInvoiceValue.Location = new System.Drawing.Point(196, 2);
            this.labelInvoiceValue.Name = "labelInvoiceValue";
            this.labelInvoiceValue.Size = new System.Drawing.Size(63, 20);
            this.labelInvoiceValue.TabIndex = 1;
            this.labelInvoiceValue.Text = "0,00 zł";
            this.labelInvoiceValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(57, 2);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Wartość brutto:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(127, 52);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Zapłacono:";
            // 
            // textBoxAmountPaid
            // 
            this.textBoxAmountPaid.Location = new System.Drawing.Point(196, 48);
            this.textBoxAmountPaid.Name = "textBoxAmountPaid";
            this.textBoxAmountPaid.Size = new System.Drawing.Size(63, 20);
            this.textBoxAmountPaid.TabIndex = 2;
            this.textBoxAmountPaid.Text = "0,00";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(113, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Wartość netto:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonEditArticleOnInvoice
            // 
            this.buttonEditArticleOnInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonEditArticleOnInvoice.Location = new System.Drawing.Point(205, 506);
            this.buttonEditArticleOnInvoice.Name = "buttonEditArticleOnInvoice";
            this.buttonEditArticleOnInvoice.Size = new System.Drawing.Size(90, 30);
            this.buttonEditArticleOnInvoice.TabIndex = 8;
            this.buttonEditArticleOnInvoice.Text = "Edytuj artykuł";
            this.buttonEditArticleOnInvoice.UseVisualStyleBackColor = true;
            this.buttonEditArticleOnInvoice.Click += new System.EventHandler(this.buttonEditArticleOnInvoice_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // FormInvoiceEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 626);
            this.Controls.Add(this.buttonEditArticleOnInvoice);
            this.Controls.Add(this.tableLayoutPanel9);
            this.Controls.Add(this.buttonRemoveArticleFromInvoice);
            this.Controls.Add(this.buttonAddArticleToInvoice);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.buttonSaveInvoice);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormInvoiceEditor";
            this.Text = "Stwórz nowy dokument";
            this.Load += new System.EventHandler(this.AddNewInvoice_Load);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateSale;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBoxInvoiceNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateInvoice;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePickerDatePayment;
        private System.Windows.Forms.ComboBox comboBoxPayMethod;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button buttonSaveInvoice;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonChooseCustomer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxSelectPaymentDate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelCustomerAdress;
        private System.Windows.Forms.Label labelCustomerNIP;
        private System.Windows.Forms.Label labelCustomerName;
        private System.Windows.Forms.Button buttonAddArticleToInvoice;
        private System.Windows.Forms.Button buttonRemoveArticleFromInvoice;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelInvoiceValue;
        private System.Windows.Forms.Label labelInvoiceTotalNetto;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxAmountPaid;
        private System.Windows.Forms.Button buttonEditArticleOnInvoice;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nr;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceNetto;
        private System.Windows.Forms.DataGridViewTextBoxColumn vat;
        private System.Windows.Forms.DataGridViewTextBoxColumn price_brutto;
        private System.Windows.Forms.DataGridViewTextBoxColumn discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn measureUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueNetto;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueBrutto;


    }
}