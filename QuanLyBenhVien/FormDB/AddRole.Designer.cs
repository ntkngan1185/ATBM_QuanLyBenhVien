namespace QuanLyBenhVien.FormDB
{
    partial class AddRole
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
            this.lbl_title = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_rolename = new System.Windows.Forms.TextBox();
            this.btn_createrole = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(90)))), ((int)(((byte)(82)))));
            this.lbl_title.Location = new System.Drawing.Point(46, 27);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(135, 32);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "ADD ROLE";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(90)))), ((int)(((byte)(82)))));
            this.panel1.Location = new System.Drawing.Point(52, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(720, 4);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(296, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Role name";
            // 
            // txt_rolename
            // 
            this.txt_rolename.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_rolename.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_rolename.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(90)))), ((int)(((byte)(82)))));
            this.txt_rolename.Location = new System.Drawing.Point(300, 192);
            this.txt_rolename.Name = "txt_rolename";
            this.txt_rolename.Size = new System.Drawing.Size(267, 29);
            this.txt_rolename.TabIndex = 3;
            // 
            // btn_createrole
            // 
            this.btn_createrole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(98)))), ((int)(((byte)(90)))));
            this.btn_createrole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_createrole.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_createrole.ForeColor = System.Drawing.Color.White;
            this.btn_createrole.Location = new System.Drawing.Point(301, 260);
            this.btn_createrole.Name = "btn_createrole";
            this.btn_createrole.Size = new System.Drawing.Size(266, 42);
            this.btn_createrole.TabIndex = 4;
            this.btn_createrole.Text = "Create Role";
            this.btn_createrole.UseVisualStyleBackColor = false;
            this.btn_createrole.Click += new System.EventHandler(this.btn_createrole_Click);
            // 
            // AddRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(839, 475);
            this.Controls.Add(this.btn_createrole);
            this.Controls.Add(this.txt_rolename);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_title);
            this.Name = "AddRole";
            this.Text = "Add Role";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_rolename;
        private System.Windows.Forms.Button btn_createrole;
    }
}