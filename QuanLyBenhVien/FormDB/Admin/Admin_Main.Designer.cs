namespace QuanLyBenhVien.FormDB.Admin
{
    partial class Admin_Main
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
            this.ql_addemp = new System.Windows.Forms.Button();
            this.ql_csyt = new System.Windows.Forms.Button();
            this.ql_patient = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(909, 104);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(273, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "XIN CHÀO, QUẢN LÝ";
            // 
            // ql_addemp
            // 
            this.ql_addemp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(98)))), ((int)(((byte)(90)))));
            this.ql_addemp.FlatAppearance.BorderSize = 0;
            this.ql_addemp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ql_addemp.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ql_addemp.ForeColor = System.Drawing.Color.White;
            this.ql_addemp.Location = new System.Drawing.Point(331, 178);
            this.ql_addemp.Name = "ql_addemp";
            this.ql_addemp.Size = new System.Drawing.Size(209, 47);
            this.ql_addemp.TabIndex = 5;
            this.ql_addemp.Text = "Thêm nhân viên";
            this.ql_addemp.UseVisualStyleBackColor = false;
            this.ql_addemp.Click += new System.EventHandler(this.ql_addemp_Click);
            // 
            // ql_csyt
            // 
            this.ql_csyt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(98)))), ((int)(((byte)(90)))));
            this.ql_csyt.FlatAppearance.BorderSize = 0;
            this.ql_csyt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ql_csyt.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ql_csyt.ForeColor = System.Drawing.Color.White;
            this.ql_csyt.Location = new System.Drawing.Point(331, 264);
            this.ql_csyt.Name = "ql_csyt";
            this.ql_csyt.Size = new System.Drawing.Size(209, 47);
            this.ql_csyt.TabIndex = 6;
            this.ql_csyt.Text = "Quản lý Cơ sở y tế";
            this.ql_csyt.UseVisualStyleBackColor = false;
            this.ql_csyt.Click += new System.EventHandler(this.ql_csyt_Click);
            // 
            // ql_patient
            // 
            this.ql_patient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(98)))), ((int)(((byte)(90)))));
            this.ql_patient.FlatAppearance.BorderSize = 0;
            this.ql_patient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ql_patient.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ql_patient.ForeColor = System.Drawing.Color.White;
            this.ql_patient.Location = new System.Drawing.Point(331, 350);
            this.ql_patient.Name = "ql_patient";
            this.ql_patient.Size = new System.Drawing.Size(209, 47);
            this.ql_patient.TabIndex = 7;
            this.ql_patient.Text = "Thêm bệnh nhân";
            this.ql_patient.UseVisualStyleBackColor = false;
            this.ql_patient.Click += new System.EventHandler(this.ql_patient_Click);
            // 
            // Admin_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(909, 502);
            this.Controls.Add(this.ql_patient);
            this.Controls.Add(this.ql_csyt);
            this.Controls.Add(this.ql_addemp);
            this.Controls.Add(this.panel1);
            this.Name = "Admin_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin_Main";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ql_addemp;
        private System.Windows.Forms.Button ql_csyt;
        private System.Windows.Forms.Button ql_patient;
    }
}