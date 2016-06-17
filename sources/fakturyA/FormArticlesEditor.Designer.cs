﻿namespace fakturyA
{
    partial class FormArticlesEditor
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
            this.Code_TB = new System.Windows.Forms.TextBox();
            this.Name_TB = new System.Windows.Forms.TextBox();
            this.Vat_CB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Measure_CB = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.FormArticleEditor_Button = new System.Windows.Forms.Button();
            this.PriceBrutto_TB = new System.Windows.Forms.TextBox();
            this.PriceNetto_TB = new System.Windows.Forms.TextBox();
            this.PriceBrutto_RB = new System.Windows.Forms.RadioButton();
            this.PriceNetto_RB = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kod";
            // 
            // Code_TB
            // 
            this.Code_TB.Location = new System.Drawing.Point(127, 24);
            this.Code_TB.Name = "Code_TB";
            this.Code_TB.Size = new System.Drawing.Size(100, 20);
            this.Code_TB.TabIndex = 1;
            // 
            // Name_TB
            // 
            this.Name_TB.Location = new System.Drawing.Point(127, 60);
            this.Name_TB.Name = "Name_TB";
            this.Name_TB.Size = new System.Drawing.Size(100, 20);
            this.Name_TB.TabIndex = 5;
            // 
            // Vat_CB
            // 
            this.Vat_CB.Items.AddRange(new object[] {
            "23,00",
            "8,00",
            "5,00"});
            this.Vat_CB.Location = new System.Drawing.Point(127, 137);
            this.Vat_CB.Name = "Vat_CB";
            this.Vat_CB.Size = new System.Drawing.Size(100, 21);
            this.Vat_CB.TabIndex = 6;
            this.Vat_CB.Leave += new System.EventHandler(this.changeDataInTB);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nazwa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Jednostka Miary";
            // 
            // Measure_CB
            // 
            this.Measure_CB.Items.AddRange(new object[] {
            "usluga",
            "sztuka",
            "opakowanie",
            "m2",
            "kg",
            "litr",
            "m"});
            this.Measure_CB.Location = new System.Drawing.Point(127, 97);
            this.Measure_CB.Name = "Measure_CB";
            this.Measure_CB.Size = new System.Drawing.Size(100, 21);
            this.Measure_CB.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Vat ";
            // 
            // FormArticleEditor_Button
            // 
            this.FormArticleEditor_Button.Location = new System.Drawing.Point(301, 254);
            this.FormArticleEditor_Button.Name = "FormArticleEditor_Button";
            this.FormArticleEditor_Button.Size = new System.Drawing.Size(75, 23);
            this.FormArticleEditor_Button.TabIndex = 12;
            this.FormArticleEditor_Button.Text = "button1";
            this.FormArticleEditor_Button.UseVisualStyleBackColor = true;
            this.FormArticleEditor_Button.Click += new System.EventHandler(this.button1_Click);
            // 
            // PriceBrutto_TB
            // 
            this.PriceBrutto_TB.Location = new System.Drawing.Point(127, 175);
            this.PriceBrutto_TB.Name = "PriceBrutto_TB";
            this.PriceBrutto_TB.Size = new System.Drawing.Size(100, 20);
            this.PriceBrutto_TB.TabIndex = 13;
            this.PriceBrutto_TB.Enter += new System.EventHandler(this.changeDataInTB);
            this.PriceBrutto_TB.Leave += new System.EventHandler(this.changeDataInTB);
            // 
            // PriceNetto_TB
            // 
            this.PriceNetto_TB.Location = new System.Drawing.Point(127, 207);
            this.PriceNetto_TB.Name = "PriceNetto_TB";
            this.PriceNetto_TB.Size = new System.Drawing.Size(100, 20);
            this.PriceNetto_TB.TabIndex = 14;
            this.PriceNetto_TB.Leave += new System.EventHandler(this.changeDataInTB);
            // 
            // PriceBrutto_RB
            // 
            this.PriceBrutto_RB.AutoSize = true;
            this.PriceBrutto_RB.Location = new System.Drawing.Point(29, 176);
            this.PriceBrutto_RB.Name = "PriceBrutto_RB";
            this.PriceBrutto_RB.Size = new System.Drawing.Size(80, 17);
            this.PriceBrutto_RB.TabIndex = 15;
            this.PriceBrutto_RB.TabStop = true;
            this.PriceBrutto_RB.Text = "Cena brutto";
            this.PriceBrutto_RB.UseVisualStyleBackColor = true;
            this.PriceBrutto_RB.CheckedChanged += new System.EventHandler(this.checkedRadioButton);
            // 
            // PriceNetto_RB
            // 
            this.PriceNetto_RB.AutoSize = true;
            this.PriceNetto_RB.Location = new System.Drawing.Point(29, 209);
            this.PriceNetto_RB.Name = "PriceNetto_RB";
            this.PriceNetto_RB.Size = new System.Drawing.Size(77, 17);
            this.PriceNetto_RB.TabIndex = 16;
            this.PriceNetto_RB.TabStop = true;
            this.PriceNetto_RB.Text = "Cena netto";
            this.PriceNetto_RB.UseVisualStyleBackColor = true;
            this.PriceNetto_RB.CheckedChanged += new System.EventHandler(this.checkedRadioButton);
            // 
            // FormArticlesEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 326);
            this.Controls.Add(this.PriceNetto_RB);
            this.Controls.Add(this.PriceBrutto_RB);
            this.Controls.Add(this.PriceNetto_TB);
            this.Controls.Add(this.PriceBrutto_TB);
            this.Controls.Add(this.FormArticleEditor_Button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Measure_CB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Vat_CB);
            this.Controls.Add(this.Name_TB);
            this.Controls.Add(this.Code_TB);
            this.Controls.Add(this.label1);
            this.Name = "FormArticlesEditor";
            this.Text = "FormArticlesEditor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Code_TB;
        private System.Windows.Forms.TextBox Name_TB;
        private System.Windows.Forms.ComboBox Vat_CB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Measure_CB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button FormArticleEditor_Button;
        private System.Windows.Forms.TextBox PriceBrutto_TB;
        private System.Windows.Forms.TextBox PriceNetto_TB;
        private System.Windows.Forms.RadioButton PriceBrutto_RB;
        private System.Windows.Forms.RadioButton PriceNetto_RB;

    }
}