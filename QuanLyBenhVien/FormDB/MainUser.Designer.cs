
namespace QuanLyBenhVien.FormDB
{
    partial class MainUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainUser));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelUChildForm = new System.Windows.Forms.Panel();
            this.panelUIMenu = new System.Windows.Forms.Panel();
            this.btnListRole = new System.Windows.Forms.Button();
            this.btnGrantRole = new System.Windows.Forms.Button();
            this.btnAddRole = new System.Windows.Forms.Button();
            this.btnListUser = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnGrantUser = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnRole = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panelUIMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelUChildForm);
            this.panel1.Controls.Add(this.panelUIMenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(838, 501);
            this.panel1.TabIndex = 0;
            // 
            // panelUChildForm
            // 
            this.panelUChildForm.BackColor = System.Drawing.Color.White;
            this.panelUChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelUChildForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panelUChildForm.Location = new System.Drawing.Point(193, 0);
            this.panelUChildForm.Margin = new System.Windows.Forms.Padding(2);
            this.panelUChildForm.Name = "panelUChildForm";
            this.panelUChildForm.Size = new System.Drawing.Size(645, 501);
            this.panelUChildForm.TabIndex = 1;
            this.panelUChildForm.Paint += new System.Windows.Forms.PaintEventHandler(this.panelUChildForm_Paint);
            // 
            // panelUIMenu
            // 
            this.panelUIMenu.BackColor = System.Drawing.Color.Teal;
            this.panelUIMenu.Controls.Add(this.btn_back);
            this.panelUIMenu.Controls.Add(this.btnListRole);
            this.panelUIMenu.Controls.Add(this.btnGrantRole);
            this.panelUIMenu.Controls.Add(this.btnAddRole);
            this.panelUIMenu.Controls.Add(this.btnListUser);
            this.panelUIMenu.Controls.Add(this.btnUser);
            this.panelUIMenu.Controls.Add(this.btnGrantUser);
            this.panelUIMenu.Controls.Add(this.btnAddUser);
            this.panelUIMenu.Controls.Add(this.btnRole);
            this.panelUIMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelUIMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panelUIMenu.Location = new System.Drawing.Point(0, 0);
            this.panelUIMenu.Margin = new System.Windows.Forms.Padding(2);
            this.panelUIMenu.Name = "panelUIMenu";
            this.panelUIMenu.Size = new System.Drawing.Size(193, 501);
            this.panelUIMenu.TabIndex = 0;
            // 
            // btnListRole
            // 
            this.btnListRole.BackColor = System.Drawing.Color.Teal;
            this.btnListRole.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnListRole.FlatAppearance.BorderSize = 0;
            this.btnListRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListRole.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnListRole.ForeColor = System.Drawing.Color.White;
            this.btnListRole.Location = new System.Drawing.Point(16, 169);
            this.btnListRole.Margin = new System.Windows.Forms.Padding(2);
            this.btnListRole.Name = "btnListRole";
            this.btnListRole.Size = new System.Drawing.Size(153, 37);
            this.btnListRole.TabIndex = 7;
            this.btnListRole.Text = "Xem danh sách role";
            this.btnListRole.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListRole.UseVisualStyleBackColor = false;
            this.btnListRole.Click += new System.EventHandler(this.btnListRole_Click);
            // 
            // btnGrantRole
            // 
            this.btnGrantRole.BackColor = System.Drawing.Color.Teal;
            this.btnGrantRole.FlatAppearance.BorderSize = 0;
            this.btnGrantRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrantRole.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnGrantRole.ForeColor = System.Drawing.Color.White;
            this.btnGrantRole.Location = new System.Drawing.Point(16, 135);
            this.btnGrantRole.Margin = new System.Windows.Forms.Padding(2);
            this.btnGrantRole.Name = "btnGrantRole";
            this.btnGrantRole.Size = new System.Drawing.Size(153, 37);
            this.btnGrantRole.TabIndex = 6;
            this.btnGrantRole.Text = "Cấp quyền role";
            this.btnGrantRole.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGrantRole.UseVisualStyleBackColor = false;
            this.btnGrantRole.Click += new System.EventHandler(this.btnGrantRole_Click);
            // 
            // btnAddRole
            // 
            this.btnAddRole.BackColor = System.Drawing.Color.Teal;
            this.btnAddRole.FlatAppearance.BorderSize = 0;
            this.btnAddRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRole.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddRole.ForeColor = System.Drawing.Color.White;
            this.btnAddRole.Location = new System.Drawing.Point(16, 104);
            this.btnAddRole.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddRole.Name = "btnAddRole";
            this.btnAddRole.Size = new System.Drawing.Size(153, 37);
            this.btnAddRole.TabIndex = 5;
            this.btnAddRole.Text = "Thêm role";
            this.btnAddRole.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddRole.UseVisualStyleBackColor = false;
            this.btnAddRole.Click += new System.EventHandler(this.btnAddRole_Click);
            // 
            // btnListUser
            // 
            this.btnListUser.BackColor = System.Drawing.Color.Teal;
            this.btnListUser.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnListUser.FlatAppearance.BorderSize = 0;
            this.btnListUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListUser.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnListUser.ForeColor = System.Drawing.Color.White;
            this.btnListUser.Location = new System.Drawing.Point(16, 320);
            this.btnListUser.Margin = new System.Windows.Forms.Padding(2);
            this.btnListUser.Name = "btnListUser";
            this.btnListUser.Size = new System.Drawing.Size(153, 37);
            this.btnListUser.TabIndex = 4;
            this.btnListUser.Text = "Xem danh sách user";
            this.btnListUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListUser.UseVisualStyleBackColor = false;
            this.btnListUser.Click += new System.EventHandler(this.btnListUser_Click);
            // 
            // btnUser
            // 
            this.btnUser.BackColor = System.Drawing.Color.Teal;
            this.btnUser.FlatAppearance.BorderSize = 0;
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnUser.ForeColor = System.Drawing.Color.White;
            this.btnUser.Location = new System.Drawing.Point(9, 218);
            this.btnUser.Margin = new System.Windows.Forms.Padding(2);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(170, 45);
            this.btnUser.TabIndex = 1;
            this.btnUser.Text = "Quản lý user";
            this.btnUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUser.UseVisualStyleBackColor = false;
            // 
            // btnGrantUser
            // 
            this.btnGrantUser.BackColor = System.Drawing.Color.Teal;
            this.btnGrantUser.FlatAppearance.BorderSize = 0;
            this.btnGrantUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrantUser.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnGrantUser.ForeColor = System.Drawing.Color.White;
            this.btnGrantUser.Location = new System.Drawing.Point(16, 285);
            this.btnGrantUser.Margin = new System.Windows.Forms.Padding(2);
            this.btnGrantUser.Name = "btnGrantUser";
            this.btnGrantUser.Size = new System.Drawing.Size(153, 37);
            this.btnGrantUser.TabIndex = 3;
            this.btnGrantUser.Text = "Cấp quyền user";
            this.btnGrantUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGrantUser.UseVisualStyleBackColor = false;
            this.btnGrantUser.Click += new System.EventHandler(this.btnGrantUser_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.Color.Teal;
            this.btnAddUser.FlatAppearance.BorderSize = 0;
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddUser.ForeColor = System.Drawing.Color.White;
            this.btnAddUser.Location = new System.Drawing.Point(16, 251);
            this.btnAddUser.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(153, 37);
            this.btnAddUser.TabIndex = 2;
            this.btnAddUser.Text = "Thêm user";
            this.btnAddUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnRole
            // 
            this.btnRole.BackColor = System.Drawing.Color.Teal;
            this.btnRole.FlatAppearance.BorderSize = 0;
            this.btnRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRole.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnRole.ForeColor = System.Drawing.Color.White;
            this.btnRole.Location = new System.Drawing.Point(9, 67);
            this.btnRole.Margin = new System.Windows.Forms.Padding(2);
            this.btnRole.Name = "btnRole";
            this.btnRole.Size = new System.Drawing.Size(170, 45);
            this.btnRole.TabIndex = 0;
            this.btnRole.Text = "Quản lý role";
            this.btnRole.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRole.UseVisualStyleBackColor = false;
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Transparent;
            this.btn_back.FlatAppearance.BorderSize = 0;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Image = ((System.Drawing.Image)(resources.GetObject("btn_back.Image")));
            this.btn_back.Location = new System.Drawing.Point(16, 22);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(55, 29);
            this.btn_back.TabIndex = 50;
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // MainUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 501);
            this.Controls.Add(this.panel1);
            this.Name = "MainUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang chủ";
            this.Load += new System.EventHandler(this.MainUser_Load);
            this.panel1.ResumeLayout(false);
            this.panelUIMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelUIMenu;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Button btnRole;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnGrantUser;
        private System.Windows.Forms.Button btnListUser;
        private System.Windows.Forms.Panel panelUChildForm;
        private System.Windows.Forms.Button btnListRole;
        private System.Windows.Forms.Button btnGrantRole;
        private System.Windows.Forms.Button btnAddRole;
        private System.Windows.Forms.Button btn_back;
    }
}

