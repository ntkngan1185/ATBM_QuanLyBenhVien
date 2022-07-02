namespace QuanLyBenhVien.FormDB.ThanhTra
{
    partial class Main_ThanhTra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_ThanhTra));
            this.panelUIMenu = new System.Windows.Forms.Panel();
            this.btnViewTableTT = new System.Windows.Forms.Button();
            this.panelTTChildForm = new System.Windows.Forms.Panel();
            this.btn_back = new System.Windows.Forms.Button();
            this.panelUIMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelUIMenu
            // 
            this.panelUIMenu.BackColor = System.Drawing.Color.Teal;
            this.panelUIMenu.Controls.Add(this.btnViewTableTT);
            this.panelUIMenu.Controls.Add(this.btn_back);
            this.panelUIMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelUIMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panelUIMenu.Location = new System.Drawing.Point(0, 0);
            this.panelUIMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelUIMenu.Name = "panelUIMenu";
            this.panelUIMenu.Size = new System.Drawing.Size(244, 603);
            this.panelUIMenu.TabIndex = 1;
            // 
            // btnViewTableTT
            // 
            this.btnViewTableTT.BackColor = System.Drawing.Color.Teal;
            this.btnViewTableTT.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnViewTableTT.FlatAppearance.BorderSize = 0;
            this.btnViewTableTT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewTableTT.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnViewTableTT.ForeColor = System.Drawing.Color.White;
            this.btnViewTableTT.Location = new System.Drawing.Point(12, 160);
            this.btnViewTableTT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnViewTableTT.Name = "btnViewTableTT";
            this.btnViewTableTT.Size = new System.Drawing.Size(226, 46);
            this.btnViewTableTT.TabIndex = 51;
            this.btnViewTableTT.Text = "Xem thông tin bảng";
            this.btnViewTableTT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewTableTT.UseVisualStyleBackColor = false;
            this.btnViewTableTT.Click += new System.EventHandler(this.btnViewTableTT_Click);
            // 
            // panelTTChildForm
            // 
            this.panelTTChildForm.BackColor = System.Drawing.Color.White;
            this.panelTTChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTTChildForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panelTTChildForm.Location = new System.Drawing.Point(244, 0);
            this.panelTTChildForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTTChildForm.Name = "panelTTChildForm";
            this.panelTTChildForm.Size = new System.Drawing.Size(746, 603);
            this.panelTTChildForm.TabIndex = 2;
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Transparent;
            this.btn_back.FlatAppearance.BorderSize = 0;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Image = ((System.Drawing.Image)(resources.GetObject("btn_back.Image")));
            this.btn_back.Location = new System.Drawing.Point(21, 27);
            this.btn_back.Margin = new System.Windows.Forms.Padding(4);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(73, 36);
            this.btn_back.TabIndex = 50;
            this.btn_back.UseVisualStyleBackColor = false;
            // 
            // Main_ThanhTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 603);
            this.Controls.Add(this.panelTTChildForm);
            this.Controls.Add(this.panelUIMenu);
            this.Name = "Main_ThanhTra";
            this.Text = "Main_ThanhTra";
            this.panelUIMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUIMenu;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btnViewTableTT;
        private System.Windows.Forms.Panel panelTTChildForm;
    }
}