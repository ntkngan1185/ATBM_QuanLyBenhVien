
namespace QuanLyBenhVien.FormDB.User
{
    partial class FormListPrivilegeUser
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnRevokePrivilege = new System.Windows.Forms.Button();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gridListPrivilegeUser = new System.Windows.Forms.DataGridView();
            this.btnListPriRoleU = new System.Windows.Forms.Button();
            this.btnListPriTableU = new System.Windows.Forms.Button();
            this.btnListPriColumnU = new System.Windows.Forms.Button();
            this.checkBoxRole = new System.Windows.Forms.CheckBox();
            this.checkBoxTable = new System.Windows.Forms.CheckBox();
            this.checkBoxColumn = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridListPrivilegeUser)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRevokePrivilege
            // 
            this.btnRevokePrivilege.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRevokePrivilege.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRevokePrivilege.BackColor = System.Drawing.Color.Teal;
            this.btnRevokePrivilege.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnRevokePrivilege.ForeColor = System.Drawing.Color.White;
            this.btnRevokePrivilege.Location = new System.Drawing.Point(625, 415);
            this.btnRevokePrivilege.Name = "btnRevokePrivilege";
            this.btnRevokePrivilege.Size = new System.Drawing.Size(251, 47);
            this.btnRevokePrivilege.TabIndex = 9;
            this.btnRevokePrivilege.Text = "Revoke Privilege";
            this.btnRevokePrivilege.UseVisualStyleBackColor = false;
            this.btnRevokePrivilege.Click += new System.EventHandler(this.btnRevokePrivilege_Click);
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(107, 41);
            this.txtUser.Multiline = true;
            this.txtUser.Name = "txtUser";
            this.txtUser.ReadOnly = true;
            this.txtUser.Size = new System.Drawing.Size(151, 35);
            this.txtUser.TabIndex = 8;
            this.txtUser.TextChanged += new System.EventHandler(this.txtUser_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(42, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 28);
            this.label1.TabIndex = 7;
            this.label1.Text = "USER";
            // 
            // gridListPrivilegeUser
            // 
            this.gridListPrivilegeUser.AllowUserToAddRows = false;
            this.gridListPrivilegeUser.AllowUserToDeleteRows = false;
            this.gridListPrivilegeUser.AllowUserToOrderColumns = true;
            this.gridListPrivilegeUser.AllowUserToResizeColumns = false;
            this.gridListPrivilegeUser.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridListPrivilegeUser.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.gridListPrivilegeUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridListPrivilegeUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridListPrivilegeUser.BackgroundColor = System.Drawing.Color.White;
            this.gridListPrivilegeUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridListPrivilegeUser.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridListPrivilegeUser.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridListPrivilegeUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gridListPrivilegeUser.ColumnHeadersHeight = 35;
            this.gridListPrivilegeUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridListPrivilegeUser.Cursor = System.Windows.Forms.Cursors.Arrow;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridListPrivilegeUser.DefaultCellStyle = dataGridViewCellStyle7;
            this.gridListPrivilegeUser.EnableHeadersVisualStyles = false;
            this.gridListPrivilegeUser.Location = new System.Drawing.Point(13, 150);
            this.gridListPrivilegeUser.Margin = new System.Windows.Forms.Padding(4);
            this.gridListPrivilegeUser.Name = "gridListPrivilegeUser";
            this.gridListPrivilegeUser.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(98)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(98)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridListPrivilegeUser.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.gridListPrivilegeUser.RowHeadersVisible = false;
            this.gridListPrivilegeUser.RowHeadersWidth = 50;
            this.gridListPrivilegeUser.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridListPrivilegeUser.RowTemplate.Height = 40;
            this.gridListPrivilegeUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridListPrivilegeUser.Size = new System.Drawing.Size(895, 244);
            this.gridListPrivilegeUser.TabIndex = 6;
            this.gridListPrivilegeUser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridListPrivilegeUser_CellContentClick);
            // 
            // btnListPriRoleU
            // 
            this.btnListPriRoleU.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnListPriRoleU.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnListPriRoleU.BackColor = System.Drawing.Color.Teal;
            this.btnListPriRoleU.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnListPriRoleU.ForeColor = System.Drawing.Color.White;
            this.btnListPriRoleU.Location = new System.Drawing.Point(348, 25);
            this.btnListPriRoleU.Name = "btnListPriRoleU";
            this.btnListPriRoleU.Size = new System.Drawing.Size(156, 47);
            this.btnListPriRoleU.TabIndex = 10;
            this.btnListPriRoleU.Text = "Role";
            this.btnListPriRoleU.UseVisualStyleBackColor = false;
            this.btnListPriRoleU.Click += new System.EventHandler(this.btnListPriRoleU_Click);
            // 
            // btnListPriTableU
            // 
            this.btnListPriTableU.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnListPriTableU.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnListPriTableU.BackColor = System.Drawing.Color.Teal;
            this.btnListPriTableU.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnListPriTableU.ForeColor = System.Drawing.Color.White;
            this.btnListPriTableU.Location = new System.Drawing.Point(534, 25);
            this.btnListPriTableU.Name = "btnListPriTableU";
            this.btnListPriTableU.Size = new System.Drawing.Size(156, 47);
            this.btnListPriTableU.TabIndex = 11;
            this.btnListPriTableU.Text = "Table";
            this.btnListPriTableU.UseVisualStyleBackColor = false;
            this.btnListPriTableU.Click += new System.EventHandler(this.btnListPriTableU_Click);
            // 
            // btnListPriColumnU
            // 
            this.btnListPriColumnU.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnListPriColumnU.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnListPriColumnU.BackColor = System.Drawing.Color.Teal;
            this.btnListPriColumnU.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnListPriColumnU.ForeColor = System.Drawing.Color.White;
            this.btnListPriColumnU.Location = new System.Drawing.Point(720, 25);
            this.btnListPriColumnU.Name = "btnListPriColumnU";
            this.btnListPriColumnU.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnListPriColumnU.Size = new System.Drawing.Size(156, 47);
            this.btnListPriColumnU.TabIndex = 12;
            this.btnListPriColumnU.Text = "Column";
            this.btnListPriColumnU.UseVisualStyleBackColor = false;
            this.btnListPriColumnU.Click += new System.EventHandler(this.btnListPriColumnU_Click);
            // 
            // checkBoxRole
            // 
            this.checkBoxRole.AutoSize = true;
            this.checkBoxRole.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.checkBoxRole.ForeColor = System.Drawing.Color.Red;
            this.checkBoxRole.Location = new System.Drawing.Point(378, 95);
            this.checkBoxRole.Name = "checkBoxRole";
            this.checkBoxRole.Size = new System.Drawing.Size(81, 32);
            this.checkBoxRole.TabIndex = 13;
            this.checkBoxRole.Text = "ROLE";
            this.checkBoxRole.UseVisualStyleBackColor = true;
            // 
            // checkBoxTable
            // 
            this.checkBoxTable.AutoSize = true;
            this.checkBoxTable.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.checkBoxTable.ForeColor = System.Drawing.Color.Red;
            this.checkBoxTable.Location = new System.Drawing.Point(566, 95);
            this.checkBoxTable.Name = "checkBoxTable";
            this.checkBoxTable.Size = new System.Drawing.Size(89, 32);
            this.checkBoxTable.TabIndex = 14;
            this.checkBoxTable.Text = "TABLE";
            this.checkBoxTable.UseVisualStyleBackColor = true;
            // 
            // checkBoxColumn
            // 
            this.checkBoxColumn.AutoSize = true;
            this.checkBoxColumn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.checkBoxColumn.ForeColor = System.Drawing.Color.Red;
            this.checkBoxColumn.Location = new System.Drawing.Point(742, 95);
            this.checkBoxColumn.Name = "checkBoxColumn";
            this.checkBoxColumn.Size = new System.Drawing.Size(118, 32);
            this.checkBoxColumn.TabIndex = 15;
            this.checkBoxColumn.Text = "COLUMN";
            this.checkBoxColumn.UseVisualStyleBackColor = true;
            // 
            // FormListPrivilegeUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 486);
            this.Controls.Add(this.checkBoxColumn);
            this.Controls.Add(this.checkBoxTable);
            this.Controls.Add(this.checkBoxRole);
            this.Controls.Add(this.btnListPriColumnU);
            this.Controls.Add(this.btnListPriTableU);
            this.Controls.Add(this.btnListPriRoleU);
            this.Controls.Add(this.btnRevokePrivilege);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridListPrivilegeUser);
            this.Name = "FormListPrivilegeUser";
            this.Text = "FormListPrivilegeUser";
            this.Load += new System.EventHandler(this.FormListPrivilegeUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridListPrivilegeUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRevokePrivilege;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridListPrivilegeUser;
        private System.Windows.Forms.Button btnListPriRoleU;
        private System.Windows.Forms.Button btnListPriTableU;
        private System.Windows.Forms.Button btnListPriColumnU;
        private System.Windows.Forms.CheckBox checkBoxRole;
        private System.Windows.Forms.CheckBox checkBoxTable;
        private System.Windows.Forms.CheckBox checkBoxColumn;
    }
}