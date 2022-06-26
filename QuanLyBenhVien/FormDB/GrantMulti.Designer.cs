namespace QuanLyBenhVien.FormDB
{
    partial class GrantMulti
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GrantMulti));
            this.lbl_selectedRoleMulti = new System.Windows.Forms.Label();
            this.btn_multiadd = new System.Windows.Forms.Button();
            this.cb_multitable = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_multiaction = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dg_multicolumn = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_title = new System.Windows.Forms.Label();
            this.btn_multiBack = new System.Windows.Forms.Button();
            this.cbAll = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dg_multicolumn)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_selectedRoleMulti
            // 
            this.lbl_selectedRoleMulti.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_selectedRoleMulti.AutoSize = true;
            this.lbl_selectedRoleMulti.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_selectedRoleMulti.Location = new System.Drawing.Point(98, 135);
            this.lbl_selectedRoleMulti.Name = "lbl_selectedRoleMulti";
            this.lbl_selectedRoleMulti.Size = new System.Drawing.Size(54, 21);
            this.lbl_selectedRoleMulti.TabIndex = 44;
            this.lbl_selectedRoleMulti.Text = "label5";
            // 
            // btn_multiadd
            // 
            this.btn_multiadd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_multiadd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(98)))), ((int)(((byte)(90)))));
            this.btn_multiadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_multiadd.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_multiadd.ForeColor = System.Drawing.Color.White;
            this.btn_multiadd.Location = new System.Drawing.Point(321, 422);
            this.btn_multiadd.Name = "btn_multiadd";
            this.btn_multiadd.Size = new System.Drawing.Size(220, 42);
            this.btn_multiadd.TabIndex = 43;
            this.btn_multiadd.Text = "Add new privilege";
            this.btn_multiadd.UseVisualStyleBackColor = false;
            this.btn_multiadd.Click += new System.EventHandler(this.btn_multiadd_Click);
            // 
            // cb_multitable
            // 
            this.cb_multitable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_multitable.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_multitable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(90)))), ((int)(((byte)(82)))));
            this.cb_multitable.FormattingEnabled = true;
            this.cb_multitable.Location = new System.Drawing.Point(102, 258);
            this.cb_multitable.Name = "cb_multitable";
            this.cb_multitable.Size = new System.Drawing.Size(154, 29);
            this.cb_multitable.TabIndex = 40;
            this.cb_multitable.SelectedIndexChanged += new System.EventHandler(this.cb_multitable_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 21);
            this.label3.TabIndex = 39;
            this.label3.Text = "Table";
            // 
            // cb_multiaction
            // 
            this.cb_multiaction.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_multiaction.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_multiaction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(90)))), ((int)(((byte)(82)))));
            this.cb_multiaction.FormattingEnabled = true;
            this.cb_multiaction.Location = new System.Drawing.Point(102, 189);
            this.cb_multiaction.Name = "cb_multiaction";
            this.cb_multiaction.Size = new System.Drawing.Size(154, 29);
            this.cb_multiaction.TabIndex = 38;
            this.cb_multiaction.SelectedIndexChanged += new System.EventHandler(this.cb_multiaction_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 21);
            this.label2.TabIndex = 37;
            this.label2.Text = "Action";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 21);
            this.label1.TabIndex = 36;
            this.label1.Text = "Role:";
            // 
            // dg_multicolumn
            // 
            this.dg_multicolumn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dg_multicolumn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_multicolumn.BackgroundColor = System.Drawing.Color.White;
            this.dg_multicolumn.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dg_multicolumn.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(205)))), ((int)(((byte)(178)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(205)))), ((int)(((byte)(178)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_multicolumn.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dg_multicolumn.ColumnHeadersHeight = 35;
            this.dg_multicolumn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dg_multicolumn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(90)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dg_multicolumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.dg_multicolumn.EnableHeadersVisualStyles = false;
            this.dg_multicolumn.Location = new System.Drawing.Point(321, 122);
            this.dg_multicolumn.Name = "dg_multicolumn";
            this.dg_multicolumn.RowHeadersVisible = false;
            this.dg_multicolumn.RowTemplate.Height = 30;
            this.dg_multicolumn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_multicolumn.Size = new System.Drawing.Size(600, 266);
            this.dg_multicolumn.TabIndex = 45;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ColumnName";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(90)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle2.NullValue = false;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column2.HeaderText = "Option";
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(90)))), ((int)(((byte)(82)))));
            this.panel2.Location = new System.Drawing.Point(89, 71);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(719, 4);
            this.panel2.TabIndex = 47;
            // 
            // lbl_title
            // 
            this.lbl_title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(90)))), ((int)(((byte)(82)))));
            this.lbl_title.Location = new System.Drawing.Point(82, 35);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(381, 32);
            this.lbl_title.TabIndex = 46;
            this.lbl_title.Text = "ADD NEW PRIVILEGE FOR ROLE";
            // 
            // btn_multiBack
            // 
            this.btn_multiBack.BackColor = System.Drawing.Color.Transparent;
            this.btn_multiBack.FlatAppearance.BorderSize = 0;
            this.btn_multiBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_multiBack.Image = ((System.Drawing.Image)(resources.GetObject("btn_multiBack.Image")));
            this.btn_multiBack.Location = new System.Drawing.Point(733, 20);
            this.btn_multiBack.Name = "btn_multiBack";
            this.btn_multiBack.Size = new System.Drawing.Size(75, 45);
            this.btn_multiBack.TabIndex = 48;
            this.btn_multiBack.UseVisualStyleBackColor = false;
            this.btn_multiBack.Click += new System.EventHandler(this.btn_multiBack_Click);
            // 
            // cbAll
            // 
            this.cbAll.AutoSize = true;
            this.cbAll.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(124)))), ((int)(((byte)(115)))));
            this.cbAll.Location = new System.Drawing.Point(102, 329);
            this.cbAll.Name = "cbAll";
            this.cbAll.Size = new System.Drawing.Size(167, 25);
            this.cbAll.TabIndex = 49;
            this.cbAll.Text = "Grant All Columns";
            this.cbAll.UseVisualStyleBackColor = true;
            // 
            // GrantMulti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(945, 516);
            this.Controls.Add(this.cbAll);
            this.Controls.Add(this.btn_multiBack);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.dg_multicolumn);
            this.Controls.Add(this.lbl_selectedRoleMulti);
            this.Controls.Add(this.btn_multiadd);
            this.Controls.Add(this.cb_multitable);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_multiaction);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GrantMulti";
            this.Text = "Grant Multi";
            ((System.ComponentModel.ISupportInitialize)(this.dg_multicolumn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_selectedRoleMulti;
        private System.Windows.Forms.Button btn_multiadd;
        private System.Windows.Forms.ComboBox cb_multitable;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_multiaction;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dg_multicolumn;
        private System.Windows.Forms.Button btn_multiBack;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column2;
        private System.Windows.Forms.CheckBox cbAll;
    }
}