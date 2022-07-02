
namespace QuanLyBenhVien.FormDB.User
{
    partial class FormGrantRoleToUser
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
            this.label2 = new System.Windows.Forms.Label();
            this.cbGrantRoleU = new System.Windows.Forms.ComboBox();
            this.btnGrantRoleUser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbUserNameRole = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(359, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 21);
            this.label2.TabIndex = 20;
            this.label2.Text = "Role";
            // 
            // cbGrantRoleU
            // 
            this.cbGrantRoleU.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGrantRoleU.FormattingEnabled = true;
            this.cbGrantRoleU.Location = new System.Drawing.Point(363, 91);
            this.cbGrantRoleU.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbGrantRoleU.Name = "cbGrantRoleU";
            this.cbGrantRoleU.Size = new System.Drawing.Size(165, 25);
            this.cbGrantRoleU.TabIndex = 19;
            // 
            // btnGrantRoleUser
            // 
            this.btnGrantRoleUser.BackColor = System.Drawing.Color.IndianRed;
            this.btnGrantRoleUser.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnGrantRoleUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGrantRoleUser.Location = new System.Drawing.Point(201, 219);
            this.btnGrantRoleUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGrantRoleUser.Name = "btnGrantRoleUser";
            this.btnGrantRoleUser.Size = new System.Drawing.Size(168, 42);
            this.btnGrantRoleUser.TabIndex = 18;
            this.btnGrantRoleUser.Text = "Grant";
            this.btnGrantRoleUser.UseVisualStyleBackColor = false;
            this.btnGrantRoleUser.Click += new System.EventHandler(this.btnGrantRoleUser_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(76, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 21);
            this.label1.TabIndex = 17;
            this.label1.Text = "User name";
            // 
            // cbUserNameRole
            // 
            this.cbUserNameRole.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUserNameRole.FormattingEnabled = true;
            this.cbUserNameRole.Location = new System.Drawing.Point(79, 91);
            this.cbUserNameRole.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbUserNameRole.Name = "cbUserNameRole";
            this.cbUserNameRole.Size = new System.Drawing.Size(160, 25);
            this.cbUserNameRole.TabIndex = 16;
            this.cbUserNameRole.SelectedIndexChanged += new System.EventHandler(this.cbUserNameRole_SelectedIndexChanged);
            // 
            // FormGrantRoleToUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbGrantRoleU);
            this.Controls.Add(this.btnGrantRoleUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbUserNameRole);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormGrantRoleToUser";
            this.Text = "FormGrantRoleToUser";
            this.Load += new System.EventHandler(this.FormGrantRoleToUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbGrantRoleU;
        private System.Windows.Forms.Button btnGrantRoleUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbUserNameRole;
    }
}