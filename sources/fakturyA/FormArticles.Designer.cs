﻿namespace fakturyA
{
    partial class FormArticles
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Kod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nazwa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JednostkaM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CenaN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CenaB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.Code_tb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Name_tb = new System.Windows.Forms.TextBox();
            this.comboBox_max = new System.Windows.Forms.ComboBox();
            this.AddArticle = new System.Windows.Forms.Button();
            this.AddArticle_butt = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.MintCream;
            //this.tableLayoutPanel1.BackgroundImage = global::fakturyA.Properties.Resources._112;
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
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Code_tb, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.Name_tb, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.comboBox_max, 6, 1);
            this.tableLayoutPanel1.Controls.Add(this.AddArticle, 8, 1);
            this.tableLayoutPanel1.Controls.Add(this.AddArticle_butt, 7, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 5, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.84746F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.15254F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 450F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1041, 510);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Kod,
            this.Nazwa,
            this.JednostkaM,
            this.CenaN,
            this.CenaB,
            this.Vat});
            this.tableLayoutPanel1.SetColumnSpan(this.dataGridView1, 10);
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 62);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1035, 445);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // Kod
            // 
            this.Kod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Kod.Frozen = true;
            this.Kod.HeaderText = "Kod";
            this.Kod.Name = "Kod";
            this.Kod.ReadOnly = true;
            this.Kod.Width = 174;
            // 
            // Nazwa
            // 
            this.Nazwa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nazwa.HeaderText = "Nazwa ";
            this.Nazwa.Name = "Nazwa";
            this.Nazwa.ReadOnly = true;
            // 
            // JednostkaM
            // 
            this.JednostkaM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.JednostkaM.HeaderText = "Jednostka Miary";
            this.JednostkaM.Name = "JednostkaM";
            this.JednostkaM.ReadOnly = true;
            // 
            // CenaN
            // 
            this.CenaN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CenaN.HeaderText = "Cena Netto zł";
            this.CenaN.Name = "CenaN";
            this.CenaN.ReadOnly = true;
            // 
            // CenaB
            // 
            this.CenaB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CenaB.HeaderText = "Cena Brutto zł";
            this.CenaB.Name = "CenaB";
            this.CenaB.ReadOnly = true;
            // 
            // Vat
            // 
            this.Vat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Vat.HeaderText = "Vat %";
            this.Vat.Name = "Vat";
            this.Vat.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(173, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kod:";
            // 
            // Code_tb
            // 
            this.Code_tb.Location = new System.Drawing.Point(211, 33);
            this.Code_tb.Name = "Code_tb";
            this.Code_tb.Size = new System.Drawing.Size(98, 20);
            this.Code_tb.TabIndex = 2;
            this.Code_tb.TextChanged += new System.EventHandler(this.FindInArticles);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(365, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nazwa:";
            // 
            // Name_tb
            // 
            this.Name_tb.Location = new System.Drawing.Point(419, 33);
            this.Name_tb.Name = "Name_tb";
            this.Name_tb.Size = new System.Drawing.Size(98, 20);
            this.Name_tb.TabIndex = 4;
            this.Name_tb.TextChanged += new System.EventHandler(this.FindInArticles);
            // 
            // comboBox_max
            // 
            this.comboBox_max.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBox_max.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_max.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox_max.Items.AddRange(new object[] {
            "2",
            "50",
            "100",
            "150",
            "200",
            "250",
            "500",
            "Wszystko"});
            this.comboBox_max.Location = new System.Drawing.Point(627, 33);
            this.comboBox_max.Name = "comboBox_max";
            this.comboBox_max.Size = new System.Drawing.Size(98, 21);
            this.comboBox_max.TabIndex = 6;
            this.comboBox_max.SelectedIndexChanged += new System.EventHandler(this.FindInArticles);
            // 
            // AddArticle
            // 
            this.AddArticle.BackColor = System.Drawing.Color.WhiteSmoke;
            //this.AddArticle.BackgroundImage = global::fakturyA.Properties.Resources.b;
            this.AddArticle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AddArticle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddArticle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddArticle.Location = new System.Drawing.Point(835, 33);
            this.AddArticle.Name = "AddArticle";
            this.AddArticle.Size = new System.Drawing.Size(98, 23);
            this.AddArticle.TabIndex = 7;
            this.AddArticle.Text = "Dodaj";
            this.AddArticle.UseVisualStyleBackColor = false;
            this.AddArticle.Click += new System.EventHandler(this.AddArticle_Click);
            // 
            // AddArticle_butt
            // 
            this.AddArticle_butt.BackColor = System.Drawing.Color.WhiteSmoke;
            //this.AddArticle_butt.BackgroundImage = global::fakturyA.Properties.Resources.b;
            this.AddArticle_butt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AddArticle_butt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddArticle_butt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddArticle_butt.ForeColor = System.Drawing.SystemColors.WindowText;
            this.AddArticle_butt.ImageKey = "(none)";
            this.AddArticle_butt.Location = new System.Drawing.Point(731, 33);
            this.AddArticle_butt.Name = "AddArticle_butt";
            this.AddArticle_butt.Size = new System.Drawing.Size(98, 23);
            this.AddArticle_butt.TabIndex = 8;
            this.AddArticle_butt.Text = "Dodaj artykul";
            this.AddArticle_butt.UseVisualStyleBackColor = false;
            this.AddArticle_butt.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(538, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Max.wyników:";
            // 
            // FormArticles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(1039, 506);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormArticles";
            this.Text = "Towary i usługi";
            this.Load += new System.EventHandler(this.FormArticles_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Code_tb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Name_tb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_max;
        private System.Windows.Forms.Button AddArticle;
        private System.Windows.Forms.Button AddArticle_butt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nazwa;
        private System.Windows.Forms.DataGridViewTextBoxColumn JednostkaM;
        private System.Windows.Forms.DataGridViewTextBoxColumn CenaN;
        private System.Windows.Forms.DataGridViewTextBoxColumn CenaB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vat;




    }
}