
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.btnRevokePrivilege.Location = new System.Drawing.Point(469, 337);
            this.btnRevokePrivilege.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRevokePrivilege.Name = "btnRevokePrivilege";
            this.btnRevokePrivilege.Size = new System.Drawing.Size(188, 38);
            this.btnRevokePrivilege.TabIndex = 9;
            this.btnRevokePrivilege.Text = "Revoke Privilege";
            this.btnRevokePrivilege.UseVisualStyleBackColor = false;
            this.btnRevokePrivilege.Click += new System.EventHandler(this.btnRevokePrivilege_Click);
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(80, 33);
            this.txtUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUser.Multiline = true;
            this.txtUser.Name = "txtUser";
            this.txtUser.ReadOnly = true;
            this.txtUser.Size = new System.Drawing.Size(114, 29);
            this.txtUser.TabIndex = 8;
            this.txtUser.TextChanged += new System.EventHandler(this.txtUser_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(32, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 21);
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
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridListPrivilegeUser.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridListPrivilegeUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridListPrivilegeUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridListPrivilegeUser.BackgroundColor = System.Drawing.Color.White;
            this.gridListPrivilegeUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridListPrivilegeUser.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridListPrivilegeUser.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridListPrivilegeUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridListPrivilegeUser.ColumnHeadersHeight = 35;
            this.gridListPrivilegeUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridListPrivilegeUser.Cursor = System.Windows.Forms.Cursors.Arrow;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridListPrivilegeUser.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridListPrivilegeUser.EnableHeadersVisualStyles = false;
            this.gridListPrivilegeUser.Location = new System.Drawing.Point(10, 122);
            this.gridListPrivilegeUser.Name = "gridListPrivilegeUser";
            this.gridListPrivilegeUser.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(98)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(98)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridListPrivilegeUser.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gridListPrivilegeUser.RowHeadersVisible = false;
            this.gridListPrivilegeUser.RowHeadersWidth = 50;
            this.gridListPrivilegeUser.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridListPrivilegeUser.RowTemplate.Height = 40;
            this.gridListPrivilegeUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridListPrivilegeUser.Size = new System.Drawing.Size(671, 198);
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
            this.btnListPriRoleU.Location = new System.Drawing.Point(261, 20);
            this.btnListPriRoleU.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnListPriRoleU.Name = "btnListPriRoleU";
            this.btnListPriRoleU.Size = new System.Drawing.Size(117, 38);
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
            this.btnListPriTableU.Location = new System.Drawing.Point(400, 20);
            this.btnListPriTableU.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnListPriTableU.Name = "btnListPriTableU";
            this.btnListPriTableU.Size = new System.Drawing.Size(117, 38);
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
            this.btnListPriColumnU.Location = new System.Drawing.Point(540, 20);
            this.btnListPriColumnU.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnListPriColumnU.Name = "btnListPriColumnU";
            this.btnListPriColumnU.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnListPriColumnU.Size = new System.Drawing.Size(117, 38);
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
            this.checkBoxRole.Location = new System.Drawing.Point(284, 77);
            this.checkBoxRole.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxRole.Name = "checkBoxRole";
            this.checkBoxRole.Size = new System.Drawing.Size(67, 25);
            this.checkBoxRole.TabIndex = 13;
            this.checkBoxRole.Text = "ROLE";
            this.checkBoxRole.UseVisualStyleBackColor = true;
            // 
            // checkBoxTable
            // 
            this.checkBoxTable.AutoSize = true;
            this.checkBoxTable.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.checkBoxTable.ForeColor = System.Drawing.Color.Red;
            this.checkBoxTable.Location = new System.Drawing.Point(424, 77);
            this.checkBoxTable.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxTable.Name = "checkBoxTable";
            this.checkBoxTable.Size = new System.Drawing.Size(74, 25);
            this.checkBoxTable.TabIndex = 14;
            this.checkBoxTable.Text = "TABLE";
            this.checkBoxTable.UseVisualStyleBackColor = true;
            // 
            // checkBoxColumn
            // 
            this.checkBoxColumn.AutoSize = true;
            this.checkBoxColumn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.checkBoxColumn.ForeColor = System.Drawing.Color.Red;
            this.checkBoxColumn.Location = new System.Drawing.Point(556, 77);
            this.checkBoxColumn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxColumn.Name = "checkBoxColumn";
            this.checkBoxColumn.Size = new System.Drawing.Size(97, 25);
            this.checkBoxColumn.TabIndex = 15;
            this.checkBoxColumn.Text = "COLUMN";
            this.checkBoxColumn.UseVisualStyleBackColor = true;
            // 
            // FormListPrivilegeUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(691, 395);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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