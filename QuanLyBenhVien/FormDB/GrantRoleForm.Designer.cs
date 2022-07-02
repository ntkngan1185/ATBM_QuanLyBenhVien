namespace QuanLyBenhVien.FormDB
{
    partial class GrantRoleForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GrantRoleForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cb_All = new System.Windows.Forms.CheckBox();
            this.dg_grantcol = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btn_grantRole = new System.Windows.Forms.Button();
            this.cbTableRole = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbSelectActionRole = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbSelectRole = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_title = new System.Windows.Forms.Label();
            this.btn_multiBack = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_grantcol)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.btn_multiBack);
            this.panel1.Controls.Add(this.cb_All);
            this.panel1.Controls.Add(this.dg_grantcol);
            this.panel1.Controls.Add(this.btn_grantRole);
            this.panel1.Controls.Add(this.cbTableRole);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cbSelectActionRole);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbSelectRole);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lbl_title);
            this.panel1.Location = new System.Drawing.Point(-3, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(946, 478);
            this.panel1.TabIndex = 0;
            // 
            // cb_All
            // 
            this.cb_All.AutoSize = true;
            this.cb_All.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_All.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(124)))), ((int)(((byte)(115)))));
            this.cb_All.Location = new System.Drawing.Point(160, 342);
            this.cb_All.Name = "cb_All";
            this.cb_All.Size = new System.Drawing.Size(167, 25);
            this.cb_All.TabIndex = 50;
            this.cb_All.Text = "Grant All Columns";
            this.cb_All.UseVisualStyleBackColor = true;
            this.cb_All.CheckedChanged += new System.EventHandler(this.cb_All_CheckedChanged);
            // 
            // dg_grantcol
            // 
            this.dg_grantcol.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dg_grantcol.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_grantcol.BackgroundColor = System.Drawing.Color.White;
            this.dg_grantcol.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dg_grantcol.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(205)))), ((int)(((byte)(178)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(205)))), ((int)(((byte)(178)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_grantcol.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dg_grantcol.ColumnHeadersHeight = 35;
            this.dg_grantcol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dg_grantcol.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dg_grantcol.DefaultCellStyle = dataGridViewCellStyle4;
            this.dg_grantcol.EnableHeadersVisualStyles = false;
            this.dg_grantcol.Location = new System.Drawing.Point(364, 103);
            this.dg_grantcol.Name = "dg_grantcol";
            this.dg_grantcol.RowHeadersVisible = false;
            this.dg_grantcol.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dg_grantcol.RowTemplate.Height = 30;
            this.dg_grantcol.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_grantcol.Size = new System.Drawing.Size(553, 246);
            this.dg_grantcol.TabIndex = 46;
            // 
            // Column1
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(90)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column1.HeaderText = "ColumnName";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(90)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle3.NullValue = false;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column2.HeaderText = "Option";
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btn_grantRole
            // 
            this.btn_grantRole.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_grantRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(98)))), ((int)(((byte)(90)))));
            this.btn_grantRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_grantRole.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_grantRole.ForeColor = System.Drawing.Color.White;
            this.btn_grantRole.Location = new System.Drawing.Point(334, 396);
            this.btn_grantRole.Name = "btn_grantRole";
            this.btn_grantRole.Size = new System.Drawing.Size(265, 42);
            this.btn_grantRole.TabIndex = 23;
            this.btn_grantRole.Text = "Grant ";
            this.btn_grantRole.UseVisualStyleBackColor = false;
            this.btn_grantRole.Click += new System.EventHandler(this.btn_grantRole_Click);
            // 
            // cbTableRole
            // 
            this.cbTableRole.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbTableRole.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTableRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(90)))), ((int)(((byte)(82)))));
            this.cbTableRole.FormattingEnabled = true;
            this.cbTableRole.Location = new System.Drawing.Point(160, 271);
            this.cbTableRole.Name = "cbTableRole";
            this.cbTableRole.Size = new System.Drawing.Size(154, 29);
            this.cbTableRole.TabIndex = 20;
            this.cbTableRole.SelectedIndexChanged += new System.EventHandler(this.cbTableRole_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(92, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 21);
            this.label3.TabIndex = 19;
            this.label3.Text = "Table";
            // 
            // cbSelectActionRole
            // 
            this.cbSelectActionRole.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbSelectActionRole.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSelectActionRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(90)))), ((int)(((byte)(82)))));
            this.cbSelectActionRole.FormattingEnabled = true;
            this.cbSelectActionRole.Location = new System.Drawing.Point(160, 189);
            this.cbSelectActionRole.Name = "cbSelectActionRole";
            this.cbSelectActionRole.Size = new System.Drawing.Size(154, 29);
            this.cbSelectActionRole.TabIndex = 18;
            this.cbSelectActionRole.SelectedIndexChanged += new System.EventHandler(this.cbSelectActionRole_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(92, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 21);
            this.label2.TabIndex = 17;
            this.label2.Text = "Action";
            // 
            // cbSelectRole
            // 
            this.cbSelectRole.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbSelectRole.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbSelectRole.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSelectRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(90)))), ((int)(((byte)(82)))));
            this.cbSelectRole.FormattingEnabled = true;
            this.cbSelectRole.Location = new System.Drawing.Point(160, 118);
            this.cbSelectRole.Name = "cbSelectRole";
            this.cbSelectRole.Size = new System.Drawing.Size(154, 29);
            this.cbSelectRole.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 21);
            this.label1.TabIndex = 15;
            this.label1.Text = "Role";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(90)))), ((int)(((byte)(82)))));
            this.panel2.Location = new System.Drawing.Point(93, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(719, 4);
            this.panel2.TabIndex = 14;
            // 
            // lbl_title
            // 
            this.lbl_title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(90)))), ((int)(((byte)(82)))));
            this.lbl_title.Location = new System.Drawing.Point(86, 34);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(348, 32);
            this.lbl_title.TabIndex = 13;
            this.lbl_title.Text = "GRANT PRIVILEGE FOR ROLE";
            // 
            // btn_multiBack
            // 
            this.btn_multiBack.BackColor = System.Drawing.Color.Transparent;
            this.btn_multiBack.FlatAppearance.BorderSize = 0;
            this.btn_multiBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_multiBack.Image = ((System.Drawing.Image)(resources.GetObject("btn_multiBack.Image")));
            this.btn_multiBack.Location = new System.Drawing.Point(737, 19);
            this.btn_multiBack.Name = "btn_multiBack";
            this.btn_multiBack.Size = new System.Drawing.Size(75, 45);
            this.btn_multiBack.TabIndex = 51;
            this.btn_multiBack.UseVisualStyleBackColor = false;
            // 
            // GrantRoleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(955, 476);
            this.Controls.Add(this.panel1);
            this.Name = "GrantRoleForm";
            this.Text = "GrantRoleForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_grantcol)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_grantRole;
        private System.Windows.Forms.ComboBox cbTableRole;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbSelectActionRole;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbSelectRole;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.DataGridView dg_grantcol;
        private System.Windows.Forms.CheckBox cb_All;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column2;
        private System.Windows.Forms.Button btn_multiBack;
    }
}