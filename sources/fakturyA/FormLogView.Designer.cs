namespace fakturyA
{
    partial class FormLogView
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
            this.kto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.co_zrobil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ktora_tabela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.przed_zmiana = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.po_zmianie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kiedy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.who_tb = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.MintCream;
            this.tableLayoutPanel1.ColumnCount = 10;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.278351F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.278351F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.278351F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.30928F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.30928F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.30928F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.30928F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.30928F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.30928F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.30928F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.who_tb, 2, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.84746F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.15254F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 450F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(853, 513);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kto,
            this.co_zrobil,
            this.ktora_tabela,
            this.przed_zmiana,
            this.po_zmianie,
            this.kiedy});
            this.tableLayoutPanel1.SetColumnSpan(this.dataGridView1, 10);
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 65);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(847, 445);
            this.dataGridView1.TabIndex = 0;
            // 
            // kto
            // 
            this.kto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.kto.FillWeight = 80F;
            this.kto.Frozen = true;
            this.kto.HeaderText = "Kto";
            this.kto.Name = "kto";
            this.kto.ReadOnly = true;
            this.kto.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.kto.Width = 170;
            // 
            // co_zrobil
            // 
            this.co_zrobil.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.co_zrobil.FillWeight = 129.6296F;
            this.co_zrobil.HeaderText = "Co zrobił";
            this.co_zrobil.Name = "co_zrobil";
            this.co_zrobil.ReadOnly = true;
            // 
            // ktora_tabela
            // 
            this.ktora_tabela.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ktora_tabela.FillWeight = 92.59259F;
            this.ktora_tabela.HeaderText = "W jakiej tabeli";
            this.ktora_tabela.Name = "ktora_tabela";
            this.ktora_tabela.ReadOnly = true;
            // 
            // przed_zmiana
            // 
            this.przed_zmiana.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.przed_zmiana.FillWeight = 92.59259F;
            this.przed_zmiana.HeaderText = "Przed zmianą";
            this.przed_zmiana.Name = "przed_zmiana";
            this.przed_zmiana.ReadOnly = true;
            // 
            // po_zmianie
            // 
            this.po_zmianie.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.po_zmianie.FillWeight = 92.59259F;
            this.po_zmianie.HeaderText = "Po zmianie";
            this.po_zmianie.Name = "po_zmianie";
            this.po_zmianie.ReadOnly = true;
            // 
            // kiedy
            // 
            this.kiedy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.kiedy.FillWeight = 60F;
            this.kiedy.HeaderText = "Kiedy";
            this.kiedy.Name = "kiedy";
            this.kiedy.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(129, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kto:";
            // 
            // who_tb
            // 
            this.who_tb.Location = new System.Drawing.Point(161, 35);
            this.who_tb.Name = "who_tb";
            this.who_tb.Size = new System.Drawing.Size(70, 20);
            this.who_tb.TabIndex = 2;
            // 
            // FormLogView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 607);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormLogView";
            this.Text = "Logi";
            this.Load += new System.EventHandler(this.FormLogView_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn kto;
        private System.Windows.Forms.DataGridViewTextBoxColumn co_zrobil;
        private System.Windows.Forms.DataGridViewTextBoxColumn ktora_tabela;
        private System.Windows.Forms.DataGridViewTextBoxColumn przed_zmiana;
        private System.Windows.Forms.DataGridViewTextBoxColumn po_zmianie;
        private System.Windows.Forms.DataGridViewTextBoxColumn kiedy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox who_tb;
    }
}