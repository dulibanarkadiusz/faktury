namespace fakturyA
{
    partial class UserControl_PermissionsEditor
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
            this.labelUser = new System.Windows.Forms.Label();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.pictureBoxSuperUser = new System.Windows.Forms.PictureBox();
            this.userControl_PermissionViewCustomer = new fakturyA.UserControl_PermissionView();
            this.userControl_PermissionViewInvoice = new fakturyA.UserControl_PermissionView();
            this.userControl_PermissionViewArticles = new fakturyA.UserControl_PermissionView();
            this.buttonRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSuperUser)).BeginInit();
            this.SuspendLayout();
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(33, 14);
            this.labelUser.MaximumSize = new System.Drawing.Size(280, 0);
            this.labelUser.MinimumSize = new System.Drawing.Size(280, 0);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(280, 13);
            this.labelUser.TabIndex = 3;
            this.labelUser.Text = "username (Name Surname)";
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(635, 9);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(63, 23);
            this.buttonEdit.TabIndex = 4;
            this.buttonEdit.Text = "Edytuj";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // pictureBoxSuperUser
            // 
            this.pictureBoxSuperUser.Image = global::fakturyA.Properties.Resources.ico_star;
            this.pictureBoxSuperUser.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxSuperUser.Name = "pictureBoxSuperUser";
            this.pictureBoxSuperUser.Size = new System.Drawing.Size(19, 17);
            this.pictureBoxSuperUser.TabIndex = 5;
            this.pictureBoxSuperUser.TabStop = false;
            this.pictureBoxSuperUser.Tag = "x";
            this.pictureBoxSuperUser.Visible = false;
            // 
            // userControl_PermissionViewCustomer
            // 
            this.userControl_PermissionViewCustomer.Location = new System.Drawing.Point(533, -1);
            this.userControl_PermissionViewCustomer.Name = "userControl_PermissionViewCustomer";
            this.userControl_PermissionViewCustomer.Size = new System.Drawing.Size(96, 40);
            this.userControl_PermissionViewCustomer.TabIndex = 2;
            // 
            // userControl_PermissionViewInvoice
            // 
            this.userControl_PermissionViewInvoice.Location = new System.Drawing.Point(431, -1);
            this.userControl_PermissionViewInvoice.Name = "userControl_PermissionViewInvoice";
            this.userControl_PermissionViewInvoice.Size = new System.Drawing.Size(96, 40);
            this.userControl_PermissionViewInvoice.TabIndex = 1;
            // 
            // userControl_PermissionViewArticles
            // 
            this.userControl_PermissionViewArticles.Location = new System.Drawing.Point(329, -1);
            this.userControl_PermissionViewArticles.Name = "userControl_PermissionViewArticles";
            this.userControl_PermissionViewArticles.Size = new System.Drawing.Size(96, 40);
            this.userControl_PermissionViewArticles.TabIndex = 0;
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(703, 9);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(63, 23);
            this.buttonRemove.TabIndex = 6;
            this.buttonRemove.Text = "Usuń";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // UserControl_PermissionsEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.pictureBoxSuperUser);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.userControl_PermissionViewCustomer);
            this.Controls.Add(this.userControl_PermissionViewInvoice);
            this.Controls.Add(this.userControl_PermissionViewArticles);
            this.Name = "UserControl_PermissionsEditor";
            this.Size = new System.Drawing.Size(771, 37);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSuperUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControl_PermissionView userControl_PermissionViewArticles;
        private UserControl_PermissionView userControl_PermissionViewInvoice;
        private UserControl_PermissionView userControl_PermissionViewCustomer;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.PictureBox pictureBoxSuperUser;
        private System.Windows.Forms.Button buttonRemove;

    }
}
