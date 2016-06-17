namespace fakturyA
{
    partial class FormArticleEditor
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Code_textbox = new System.Windows.Forms.TextBox();
            this.Name_textbox = new System.Windows.Forms.TextBox();
            this.priceNetto_textbox = new System.Windows.Forms.TextBox();
            this.Vat_box = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.addEditArticleButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kod";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nazwa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cena Netto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Stawka VAT %";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Jednostka Miary";
            // 
            // Code_textbox
            // 
            this.Code_textbox.Location = new System.Drawing.Point(136, 45);
            this.Code_textbox.Name = "Code_textbox";
            this.Code_textbox.Size = new System.Drawing.Size(100, 20);
            this.Code_textbox.TabIndex = 5;
            // 
            // Name_textbox
            // 
            this.Name_textbox.Location = new System.Drawing.Point(136, 72);
            this.Name_textbox.Name = "Name_textbox";
            this.Name_textbox.Size = new System.Drawing.Size(100, 20);
            this.Name_textbox.TabIndex = 6;
            // 
            // priceNetto_textbox
            // 
            this.priceNetto_textbox.Location = new System.Drawing.Point(136, 101);
            this.priceNetto_textbox.Name = "priceNetto_textbox";
            this.priceNetto_textbox.Size = new System.Drawing.Size(100, 20);
            this.priceNetto_textbox.TabIndex = 7;
            // 
            // Vat_box
            // 
            this.Vat_box.FormattingEnabled = true;
            this.Vat_box.Items.AddRange(new object[] {
            "23",
            "8",
            "5",
            "0"});
            this.Vat_box.Location = new System.Drawing.Point(137, 133);
            this.Vat_box.Name = "Vat_box";
            this.Vat_box.Size = new System.Drawing.Size(99, 21);
            this.Vat_box.TabIndex = 8;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "usluga",
            "sztuka",
            "opakowanie",
            "m2",
            "kg",
            "litr",
            "m"});
            this.comboBox1.Location = new System.Drawing.Point(136, 161);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 9;
            // 
            // addEditArticleButton
            // 
            this.addEditArticleButton.Location = new System.Drawing.Point(258, 213);
            this.addEditArticleButton.Name = "addEditArticleButton";
            this.addEditArticleButton.Size = new System.Drawing.Size(75, 23);
            this.addEditArticleButton.TabIndex = 10;
            this.addEditArticleButton.Text = "x";
            this.addEditArticleButton.UseVisualStyleBackColor = true;
            // 
            // AddEditArticle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 361);
            this.Controls.Add(this.addEditArticleButton);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Vat_box);
            this.Controls.Add(this.priceNetto_textbox);
            this.Controls.Add(this.Name_textbox);
            this.Controls.Add(this.Code_textbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddEditArticle";
            this.Text = "AddEditArticle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Code_textbox;
        private System.Windows.Forms.TextBox Name_textbox;
        private System.Windows.Forms.TextBox priceNetto_textbox;
        private System.Windows.Forms.ComboBox Vat_box;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button addEditArticleButton;
    }
}