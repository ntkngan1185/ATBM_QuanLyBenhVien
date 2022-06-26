
namespace QuanLyBenhVien.FormDB.User
{
    partial class FormGrantPrivilegeUser
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
            this.btnGrantRoleUser = new System.Windows.Forms.Button();
            this.btnGrantPrivilegeUser = new System.Windows.Forms.Button();
            this.panelGrantPrivilege = new System.Windows.Forms.Panel();
            this.panelGrantPrivilege.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGrantRoleUser
            // 
            this.btnGrantRoleUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGrantRoleUser.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGrantRoleUser.BackColor = System.Drawing.Color.Teal;
            this.btnGrantRoleUser.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnGrantRoleUser.ForeColor = System.Drawing.Color.White;
            this.btnGrantRoleUser.Location = new System.Drawing.Point(236, 245);
            this.btnGrantRoleUser.Name = "btnGrantRoleUser";
            this.btnGrantRoleUser.Size = new System.Drawing.Size(261, 47);
            this.btnGrantRoleUser.TabIndex = 9;
            this.btnGrantRoleUser.Text = "Grant role to user";
            this.btnGrantRoleUser.UseVisualStyleBackColor = false;
            this.btnGrantRoleUser.Click += new System.EventHandler(this.btnGrantRoleUser_Click);
            // 
            // btnGrantPrivilegeUser
            // 
            this.btnGrantPrivilegeUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGrantPrivilegeUser.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGrantPrivilegeUser.BackColor = System.Drawing.Color.Teal;
            this.btnGrantPrivilegeUser.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnGrantPrivilegeUser.ForeColor = System.Drawing.Color.White;
            this.btnGrantPrivilegeUser.Location = new System.Drawing.Point(236, 126);
            this.btnGrantPrivilegeUser.Name = "btnGrantPrivilegeUser";
            this.btnGrantPrivilegeUser.Size = new System.Drawing.Size(261, 47);
            this.btnGrantPrivilegeUser.TabIndex = 8;
            this.btnGrantPrivilegeUser.Text = "Grant privilege to user";
            this.btnGrantPrivilegeUser.UseVisualStyleBackColor = false;
            this.btnGrantPrivilegeUser.Click += new System.EventHandler(this.btnGrantPrivilegeUser_Click);
            // 
            // panelGrantPrivilege
            // 
            this.panelGrantPrivilege.Controls.Add(this.btnGrantPrivilegeUser);
            this.panelGrantPrivilege.Controls.Add(this.btnGrantRoleUser);
            this.panelGrantPrivilege.Location = new System.Drawing.Point(-4, 0);
            this.panelGrantPrivilege.Name = "panelGrantPrivilege";
            this.panelGrantPrivilege.Size = new System.Drawing.Size(806, 449);
            this.panelGrantPrivilege.TabIndex = 10;
            // 
            // FormGrantPrivilegeUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelGrantPrivilege);
            this.Name = "FormGrantPrivilegeUser";
            this.Text = "FormGrantPrivilegeUser";
            this.Load += new System.EventHandler(this.FormGrantPrivilegeUser_Load);
            this.panelGrantPrivilege.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGrantRoleUser;
        private System.Windows.Forms.Button btnGrantPrivilegeUser;
        private System.Windows.Forms.Panel panelGrantPrivilege;
    }
}