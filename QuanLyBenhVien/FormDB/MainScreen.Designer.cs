namespace QuanLyBenhVien.FormDB
{
    partial class MainScreen
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_userrole = new System.Windows.Forms.Button();
            this.btn_database = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(90)))), ((int)(((byte)(82)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(891, 104);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(273, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "WELCOME, ADMIN !!!";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_userrole);
            this.panel2.Controls.Add(this.btn_database);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 104);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(891, 394);
            this.panel2.TabIndex = 1;
            // 
            // btn_userrole
            // 
            this.btn_userrole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(98)))), ((int)(((byte)(90)))));
            this.btn_userrole.FlatAppearance.BorderSize = 0;
            this.btn_userrole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_userrole.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_userrole.ForeColor = System.Drawing.Color.White;
            this.btn_userrole.Location = new System.Drawing.Point(341, 211);
            this.btn_userrole.Name = "btn_userrole";
            this.btn_userrole.Size = new System.Drawing.Size(209, 47);
            this.btn_userrole.TabIndex = 4;
            this.btn_userrole.Text = "Quản lý User/Role";
            this.btn_userrole.UseVisualStyleBackColor = false;
            this.btn_userrole.Click += new System.EventHandler(this.btn_userrole_Click);
            // 
            // btn_database
            // 
            this.btn_database.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(98)))), ((int)(((byte)(90)))));
            this.btn_database.FlatAppearance.BorderSize = 0;
            this.btn_database.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_database.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_database.ForeColor = System.Drawing.Color.White;
            this.btn_database.Location = new System.Drawing.Point(341, 137);
            this.btn_database.Name = "btn_database";
            this.btn_database.Size = new System.Drawing.Size(209, 47);
            this.btn_database.TabIndex = 3;
            this.btn_database.Text = "Quản lý Database";
            this.btn_database.UseVisualStyleBackColor = false;
            this.btn_database.Click += new System.EventHandler(this.btn_database_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(891, 498);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainScreen";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_userrole;
        private System.Windows.Forms.Button btn_database;
    }
}