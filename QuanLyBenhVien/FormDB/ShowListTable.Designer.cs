namespace QuanLyBenhVien.FormDB
{
    partial class ShowListTable
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
            this.btn_detailtable = new System.Windows.Forms.Button();
            this.dg_listtable = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dg_listtable)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_detailtable
            // 
            this.btn_detailtable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_detailtable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(98)))), ((int)(((byte)(90)))));
            this.btn_detailtable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_detailtable.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_detailtable.ForeColor = System.Drawing.Color.White;
            this.btn_detailtable.Location = new System.Drawing.Point(691, 403);
            this.btn_detailtable.Name = "btn_detailtable";
            this.btn_detailtable.Size = new System.Drawing.Size(183, 42);
            this.btn_detailtable.TabIndex = 28;
            this.btn_detailtable.Text = "Detail";
            this.btn_detailtable.UseVisualStyleBackColor = false;
            this.btn_detailtable.Click += new System.EventHandler(this.btn_detailtable_Click);
            // 
            // dg_listtable
            // 
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.dg_listtable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dg_listtable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dg_listtable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_listtable.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(205)))), ((int)(((byte)(178)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(205)))), ((int)(((byte)(178)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_listtable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dg_listtable.ColumnHeadersHeight = 35;
            this.dg_listtable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(90)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dg_listtable.DefaultCellStyle = dataGridViewCellStyle3;
            this.dg_listtable.EnableHeadersVisualStyles = false;
            this.dg_listtable.Location = new System.Drawing.Point(50, 90);
            this.dg_listtable.Name = "dg_listtable";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(98)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_listtable.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dg_listtable.RowHeadersVisible = false;
            this.dg_listtable.RowTemplate.Height = 30;
            this.dg_listtable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_listtable.Size = new System.Drawing.Size(824, 281);
            this.dg_listtable.TabIndex = 27;
            this.dg_listtable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_listtable_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(90)))), ((int)(((byte)(82)))));
            this.panel2.Location = new System.Drawing.Point(51, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(719, 4);
            this.panel2.TabIndex = 26;
            // 
            // lbl_title
            // 
            this.lbl_title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(90)))), ((int)(((byte)(82)))));
            this.lbl_title.Location = new System.Drawing.Point(44, 27);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(199, 32);
            this.lbl_title.TabIndex = 25;
            this.lbl_title.Text = "LIST OF TABLES";
            // 
            // ShowListTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(919, 491);
            this.Controls.Add(this.btn_detailtable);
            this.Controls.Add(this.dg_listtable);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lbl_title);
            this.Name = "ShowListTable";
            this.Text = "ShowListTable";
            ((System.ComponentModel.ISupportInitialize)(this.dg_listtable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_detailtable;
        private System.Windows.Forms.DataGridView dg_listtable;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_title;
    }
}