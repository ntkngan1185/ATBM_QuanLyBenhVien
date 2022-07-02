
namespace QuanLyBenhVien.FormDB.User
{
    partial class FormGrantPriToUsercs
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
            this.btnGrantPriUser = new System.Windows.Forms.Button();
            this.checkbAllow = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbColumnUser = new System.Windows.Forms.ComboBox();
            this.cbTableUser = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbActionUser = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbUserNamePri = new System.Windows.Forms.ComboBox();
            this.dg_userListCol = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dg_userListCol)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGrantPriUser
            // 
            this.btnGrantPriUser.BackColor = System.Drawing.Color.IndianRed;
            this.btnGrantPriUser.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnGrantPriUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGrantPriUser.Location = new System.Drawing.Point(58, 437);
            this.btnGrantPriUser.Name = "btnGrantPriUser";
            this.btnGrantPriUser.Size = new System.Drawing.Size(197, 48);
            this.btnGrantPriUser.TabIndex = 22;
            this.btnGrantPriUser.Text = "Grant";
            this.btnGrantPriUser.UseVisualStyleBackColor = false;
            this.btnGrantPriUser.Click += new System.EventHandler(this.btnGrantPriUser_Click);
            // 
            // checkbAllow
            // 
            this.checkbAllow.AutoSize = true;
            this.checkbAllow.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkbAllow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.checkbAllow.Location = new System.Drawing.Point(64, 386);
            this.checkbAllow.Name = "checkbAllow";
            this.checkbAllow.Size = new System.Drawing.Size(191, 25);
            this.checkbAllow.TabIndex = 21;
            this.checkbAllow.Text = "Allow grant to others";
            this.checkbAllow.UseVisualStyleBackColor = true;
            this.checkbAllow.CheckedChanged += new System.EventHandler(this.checkbAllow_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(60, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 21);
            this.label4.TabIndex = 20;
            this.label4.Text = "Column";
            // 
            // cbColumnUser
            // 
            this.cbColumnUser.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbColumnUser.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbColumnUser.FormattingEnabled = true;
            this.cbColumnUser.Location = new System.Drawing.Point(64, 329);
            this.cbColumnUser.Name = "cbColumnUser";
            this.cbColumnUser.Size = new System.Drawing.Size(160, 29);
            this.cbColumnUser.TabIndex = 19;
            // 
            // cbTableUser
            // 
            this.cbTableUser.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbTableUser.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTableUser.FormattingEnabled = true;
            this.cbTableUser.Location = new System.Drawing.Point(58, 244);
            this.cbTableUser.Name = "cbTableUser";
            this.cbTableUser.Size = new System.Drawing.Size(160, 29);
            this.cbTableUser.TabIndex = 18;
            this.cbTableUser.SelectedIndexChanged += new System.EventHandler(this.cbTableUser_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(56, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 21);
            this.label3.TabIndex = 17;
            this.label3.Text = "Table";
            // 
            // cbActionUser
            // 
            this.cbActionUser.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbActionUser.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbActionUser.FormattingEnabled = true;
            this.cbActionUser.Location = new System.Drawing.Point(58, 159);
            this.cbActionUser.Name = "cbActionUser";
            this.cbActionUser.Size = new System.Drawing.Size(160, 29);
            this.cbActionUser.TabIndex = 16;
            this.cbActionUser.SelectedIndexChanged += new System.EventHandler(this.cbActionUser_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(54, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 21);
            this.label2.TabIndex = 15;
            this.label2.Text = "Action";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(54, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 21);
            this.label1.TabIndex = 14;
            this.label1.Text = "User name";
            // 
            // cbUserNamePri
            // 
            this.cbUserNamePri.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbUserNamePri.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUserNamePri.FormattingEnabled = true;
            this.cbUserNamePri.Location = new System.Drawing.Point(58, 66);
            this.cbUserNamePri.Name = "cbUserNamePri";
            this.cbUserNamePri.Size = new System.Drawing.Size(160, 29);
            this.cbUserNamePri.TabIndex = 13;
            this.cbUserNamePri.SelectedIndexChanged += new System.EventHandler(this.cbUserNamePri_SelectedIndexChanged);
            // 
            // dg_userListCol
            // 
            this.dg_userListCol.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dg_userListCol.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_userListCol.BackgroundColor = System.Drawing.Color.White;
            this.dg_userListCol.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dg_userListCol.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(205)))), ((int)(((byte)(178)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(205)))), ((int)(((byte)(178)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_userListCol.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dg_userListCol.ColumnHeadersHeight = 35;
            this.dg_userListCol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dg_userListCol.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(90)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dg_userListCol.DefaultCellStyle = dataGridViewCellStyle2;
            this.dg_userListCol.EnableHeadersVisualStyles = false;
            this.dg_userListCol.Location = new System.Drawing.Point(313, 83);
            this.dg_userListCol.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dg_userListCol.Name = "dg_userListCol";
            this.dg_userListCol.RowHeadersVisible = false;
            this.dg_userListCol.RowTemplate.Height = 30;
            this.dg_userListCol.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_userListCol.Size = new System.Drawing.Size(581, 252);
            this.dg_userListCol.TabIndex = 23;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ColumnName";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Option";
            this.Column2.Name = "Column2";
            // 
            // FormGrantPriToUsercs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(914, 521);
            this.Controls.Add(this.dg_userListCol);
            this.Controls.Add(this.btnGrantPriUser);
            this.Controls.Add(this.checkbAllow);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbColumnUser);
            this.Controls.Add(this.cbTableUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbActionUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbUserNamePri);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormGrantPriToUsercs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormGrantPriToUsercs";
            this.Load += new System.EventHandler(this.FormGrantPriToUsercs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_userListCol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGrantPriUser;
        private System.Windows.Forms.CheckBox checkbAllow;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbColumnUser;
        private System.Windows.Forms.ComboBox cbTableUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbActionUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbUserNamePri;
        private System.Windows.Forms.DataGridView dg_userListCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column2;
    }
}