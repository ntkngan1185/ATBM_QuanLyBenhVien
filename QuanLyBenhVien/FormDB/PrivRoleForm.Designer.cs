namespace QuanLyBenhVien.FormDB
{
    partial class PrivRoleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrivRoleForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_title = new System.Windows.Forms.Label();
            this.dg_listprivrole = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_selectedRole = new System.Windows.Forms.Label();
            this.btn_addmorePriv = new System.Windows.Forms.Button();
            this.btn_revokeRole = new System.Windows.Forms.Button();
            this.btn_multiBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg_listprivrole)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(90)))), ((int)(((byte)(82)))));
            this.panel2.Location = new System.Drawing.Point(105, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(719, 4);
            this.panel2.TabIndex = 16;
            // 
            // lbl_title
            // 
            this.lbl_title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(90)))), ((int)(((byte)(82)))));
            this.lbl_title.Location = new System.Drawing.Point(98, 28);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(311, 32);
            this.lbl_title.TabIndex = 15;
            this.lbl_title.Text = "LIST PRIVILEGES OF ROLE";
            // 
            // dg_listprivrole
            // 
            this.dg_listprivrole.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dg_listprivrole.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_listprivrole.BackgroundColor = System.Drawing.Color.White;
            this.dg_listprivrole.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dg_listprivrole.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(205)))), ((int)(((byte)(178)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(205)))), ((int)(((byte)(178)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_listprivrole.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dg_listprivrole.ColumnHeadersHeight = 35;
            this.dg_listprivrole.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(90)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dg_listprivrole.DefaultCellStyle = dataGridViewCellStyle2;
            this.dg_listprivrole.EnableHeadersVisualStyles = false;
            this.dg_listprivrole.Location = new System.Drawing.Point(60, 152);
            this.dg_listprivrole.Name = "dg_listprivrole";
            this.dg_listprivrole.RowHeadersVisible = false;
            this.dg_listprivrole.RowTemplate.Height = 30;
            this.dg_listprivrole.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_listprivrole.Size = new System.Drawing.Size(882, 249);
            this.dg_listprivrole.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Role:";
            // 
            // lbl_selectedRole
            // 
            this.lbl_selectedRole.AutoSize = true;
            this.lbl_selectedRole.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_selectedRole.Location = new System.Drawing.Point(126, 101);
            this.lbl_selectedRole.Name = "lbl_selectedRole";
            this.lbl_selectedRole.Size = new System.Drawing.Size(54, 21);
            this.lbl_selectedRole.TabIndex = 19;
            this.lbl_selectedRole.Text = "label2";
            // 
            // btn_addmorePriv
            // 
            this.btn_addmorePriv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_addmorePriv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(98)))), ((int)(((byte)(90)))));
            this.btn_addmorePriv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addmorePriv.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addmorePriv.ForeColor = System.Drawing.Color.White;
            this.btn_addmorePriv.Location = new System.Drawing.Point(195, 444);
            this.btn_addmorePriv.Name = "btn_addmorePriv";
            this.btn_addmorePriv.Size = new System.Drawing.Size(183, 42);
            this.btn_addmorePriv.TabIndex = 25;
            this.btn_addmorePriv.Text = "Grant more";
            this.btn_addmorePriv.UseVisualStyleBackColor = false;
            this.btn_addmorePriv.Click += new System.EventHandler(this.btn_addmorePriv_Click);
            // 
            // btn_revokeRole
            // 
            this.btn_revokeRole.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_revokeRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(98)))), ((int)(((byte)(90)))));
            this.btn_revokeRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_revokeRole.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_revokeRole.ForeColor = System.Drawing.Color.White;
            this.btn_revokeRole.Location = new System.Drawing.Point(591, 444);
            this.btn_revokeRole.Name = "btn_revokeRole";
            this.btn_revokeRole.Size = new System.Drawing.Size(183, 42);
            this.btn_revokeRole.TabIndex = 26;
            this.btn_revokeRole.Text = "Revoke Priv";
            this.btn_revokeRole.UseVisualStyleBackColor = false;
            this.btn_revokeRole.Click += new System.EventHandler(this.btn_revokeRole_Click);
            // 
            // btn_multiBack
            // 
            this.btn_multiBack.BackColor = System.Drawing.Color.Transparent;
            this.btn_multiBack.FlatAppearance.BorderSize = 0;
            this.btn_multiBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_multiBack.Image = ((System.Drawing.Image)(resources.GetObject("btn_multiBack.Image")));
            this.btn_multiBack.Location = new System.Drawing.Point(749, 12);
            this.btn_multiBack.Name = "btn_multiBack";
            this.btn_multiBack.Size = new System.Drawing.Size(75, 45);
            this.btn_multiBack.TabIndex = 49;
            this.btn_multiBack.UseVisualStyleBackColor = false;
            // 
            // PrivRoleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(963, 531);
            this.Controls.Add(this.btn_multiBack);
            this.Controls.Add(this.btn_revokeRole);
            this.Controls.Add(this.btn_addmorePriv);
            this.Controls.Add(this.lbl_selectedRole);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dg_listprivrole);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lbl_title);
            this.Name = "PrivRoleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PrivRoleForm";
            ((System.ComponentModel.ISupportInitialize)(this.dg_listprivrole)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.DataGridView dg_listprivrole;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_selectedRole;
        private System.Windows.Forms.Button btn_addmorePriv;
        private System.Windows.Forms.Button btn_revokeRole;
        private System.Windows.Forms.Button btn_multiBack;
    }
}