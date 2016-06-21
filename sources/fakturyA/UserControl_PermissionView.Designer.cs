namespace fakturyA
{
    partial class UserControl_PermissionView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBoxSelect = new System.Windows.Forms.PictureBox();
            this.pictureBoxInsert = new System.Windows.Forms.PictureBox();
            this.pictureBoxUpdate = new System.Windows.Forms.PictureBox();
            this.pictureBoxDelete = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInsert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBoxDelete);
            this.groupBox1.Controls.Add(this.pictureBoxUpdate);
            this.groupBox1.Controls.Add(this.pictureBoxInsert);
            this.groupBox1.Controls.Add(this.pictureBoxSelect);
            this.groupBox1.Location = new System.Drawing.Point(3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(89, 34);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Artykuły";
            // 
            // pictureBoxSelect
            // 
            this.pictureBoxSelect.Image = global::fakturyA.Properties.Resources.ico_view;
            this.pictureBoxSelect.Location = new System.Drawing.Point(6, 17);
            this.pictureBoxSelect.Name = "pictureBoxSelect";
            this.pictureBoxSelect.Size = new System.Drawing.Size(14, 14);
            this.pictureBoxSelect.TabIndex = 0;
            this.pictureBoxSelect.TabStop = false;
            this.pictureBoxSelect.Visible = false;
            // 
            // pictureBoxInsert
            // 
            this.pictureBoxInsert.Image = global::fakturyA.Properties.Resources.ico_add;
            this.pictureBoxInsert.Location = new System.Drawing.Point(26, 17);
            this.pictureBoxInsert.Name = "pictureBoxInsert";
            this.pictureBoxInsert.Size = new System.Drawing.Size(14, 14);
            this.pictureBoxInsert.TabIndex = 1;
            this.pictureBoxInsert.TabStop = false;
            this.pictureBoxInsert.Visible = false;
            // 
            // pictureBoxUpdate
            // 
            this.pictureBoxUpdate.Image = global::fakturyA.Properties.Resources.ico_edit;
            this.pictureBoxUpdate.Location = new System.Drawing.Point(46, 17);
            this.pictureBoxUpdate.Name = "pictureBoxUpdate";
            this.pictureBoxUpdate.Size = new System.Drawing.Size(14, 14);
            this.pictureBoxUpdate.TabIndex = 2;
            this.pictureBoxUpdate.TabStop = false;
            this.pictureBoxUpdate.Visible = false;
            // 
            // pictureBoxDelete
            // 
            this.pictureBoxDelete.Image = global::fakturyA.Properties.Resources.ico_delete;
            this.pictureBoxDelete.Location = new System.Drawing.Point(66, 17);
            this.pictureBoxDelete.Name = "pictureBoxDelete";
            this.pictureBoxDelete.Size = new System.Drawing.Size(14, 14);
            this.pictureBoxDelete.TabIndex = 3;
            this.pictureBoxDelete.TabStop = false;
            this.pictureBoxDelete.Visible = false;
            // 
            // UserControl_PermissionView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "UserControl_PermissionView";
            this.Size = new System.Drawing.Size(96, 40);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInsert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDelete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBoxInsert;
        private System.Windows.Forms.PictureBox pictureBoxSelect;
        private System.Windows.Forms.PictureBox pictureBoxDelete;
        private System.Windows.Forms.PictureBox pictureBoxUpdate;
    }
}
