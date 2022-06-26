
namespace QuanLyBenhVien.FormDB.User
{
    partial class FormListUser
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
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.gridListUser = new System.Windows.Forms.DataGridView();
            this.panelListUser = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gridListUser)).BeginInit();
            this.panelListUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDeleteUser.BackColor = System.Drawing.Color.Teal;
            this.btnDeleteUser.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnDeleteUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeleteUser.Location = new System.Drawing.Point(660, 420);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(175, 47);
            this.btnDeleteUser.TabIndex = 4;
            this.btnDeleteUser.Text = "Delete User";
            this.btnDeleteUser.UseVisualStyleBackColor = false;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // gridListUser
            // 
            this.gridListUser.AllowUserToAddRows = false;
            this.gridListUser.AllowUserToDeleteRows = false;
            this.gridListUser.AllowUserToOrderColumns = true;
            this.gridListUser.AllowUserToResizeColumns = false;
            this.gridListUser.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridListUser.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.gridListUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridListUser.BackgroundColor = System.Drawing.Color.LightGray;
            this.gridListUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridListUser.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridListUser.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridListUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gridListUser.ColumnHeadersHeight = 35;
            this.gridListUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridListUser.Cursor = System.Windows.Forms.Cursors.Arrow;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(162)))), ((int)(((byte)(182)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridListUser.DefaultCellStyle = dataGridViewCellStyle7;
            this.gridListUser.EnableHeadersVisualStyles = false;
            this.gridListUser.Location = new System.Drawing.Point(37, 48);
            this.gridListUser.Margin = new System.Windows.Forms.Padding(4);
            this.gridListUser.Name = "gridListUser";
            this.gridListUser.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(98)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(98)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridListUser.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.gridListUser.RowHeadersVisible = false;
            this.gridListUser.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.gridListUser.RowTemplate.Height = 40;
            this.gridListUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridListUser.Size = new System.Drawing.Size(798, 340);
            this.gridListUser.TabIndex = 3;
            this.gridListUser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridListUser_CellContentClick);
            this.gridListUser.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridListUser_CellContentDoubleClick);
            // 
            // panelListUser
            // 
            this.panelListUser.Controls.Add(this.gridListUser);
            this.panelListUser.Controls.Add(this.btnDeleteUser);
            this.panelListUser.Location = new System.Drawing.Point(-2, -4);
            this.panelListUser.Name = "panelListUser";
            this.panelListUser.Size = new System.Drawing.Size(877, 500);
            this.panelListUser.TabIndex = 5;
            this.panelListUser.Paint += new System.Windows.Forms.PaintEventHandler(this.panelListUser_Paint);
            // 
            // FormListUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 495);
            this.Controls.Add(this.panelListUser);
            this.Name = "FormListUser";
            this.Text = "FormListUser";
            this.Load += new System.EventHandler(this.FormListUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridListUser)).EndInit();
            this.panelListUser.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.DataGridView gridListUser;
        private System.Windows.Forms.Panel panelListUser;
    }
}