
namespace Library_Management.View
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_admin_dashboard = new System.Windows.Forms.Button();
            this.btn_issue_dashboard = new System.Windows.Forms.Button();
            this.btn_user_dashboard = new System.Windows.Forms.Button();
            this.btn_home_dashboardd = new System.Windows.Forms.Button();
            this.panel_dashboard = new System.Windows.Forms.Panel();
            this.btn_book_dashboard = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_close_dashboard = new System.Windows.Forms.Button();
            this.lbl_dashboard = new System.Windows.Forms.Label();
            this.adminUC1 = new Library_Management.View.AdminUC();
            this.issueUC1 = new Library_Management.View.IssueUC();
            this.userUC1 = new Library_Management.View.UserUC();
            this.bookUC1 = new Library_Management.View.BookUC();
            this.homeUC1 = new Library_Management.View.HomeUC();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_admin_dashboard);
            this.panel1.Controls.Add(this.btn_issue_dashboard);
            this.panel1.Controls.Add(this.btn_user_dashboard);
            this.panel1.Controls.Add(this.btn_home_dashboardd);
            this.panel1.Controls.Add(this.panel_dashboard);
            this.panel1.Controls.Add(this.btn_book_dashboard);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(178, 700);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(22, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Management";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria Math", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, -13);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 151);
            this.label1.TabIndex = 7;
            this.label1.Text = "Library";
            // 
            // btn_admin_dashboard
            // 
            this.btn_admin_dashboard.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_admin_dashboard.FlatAppearance.BorderSize = 0;
            this.btn_admin_dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_admin_dashboard.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_admin_dashboard.ForeColor = System.Drawing.Color.White;
            this.btn_admin_dashboard.Location = new System.Drawing.Point(12, 380);
            this.btn_admin_dashboard.Name = "btn_admin_dashboard";
            this.btn_admin_dashboard.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btn_admin_dashboard.Size = new System.Drawing.Size(168, 50);
            this.btn_admin_dashboard.TabIndex = 6;
            this.btn_admin_dashboard.Text = "Admin";
            this.btn_admin_dashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_admin_dashboard.UseVisualStyleBackColor = true;
            this.btn_admin_dashboard.Click += new System.EventHandler(this.btn_admin_dashboard_Click);
            // 
            // btn_issue_dashboard
            // 
            this.btn_issue_dashboard.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_issue_dashboard.FlatAppearance.BorderSize = 0;
            this.btn_issue_dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_issue_dashboard.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_issue_dashboard.ForeColor = System.Drawing.Color.White;
            this.btn_issue_dashboard.Location = new System.Drawing.Point(12, 324);
            this.btn_issue_dashboard.Name = "btn_issue_dashboard";
            this.btn_issue_dashboard.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btn_issue_dashboard.Size = new System.Drawing.Size(168, 50);
            this.btn_issue_dashboard.TabIndex = 5;
            this.btn_issue_dashboard.Text = "Issue";
            this.btn_issue_dashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_issue_dashboard.UseVisualStyleBackColor = true;
            this.btn_issue_dashboard.Click += new System.EventHandler(this.btn_issue_dashboard_Click);
            // 
            // btn_user_dashboard
            // 
            this.btn_user_dashboard.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_user_dashboard.FlatAppearance.BorderSize = 0;
            this.btn_user_dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_user_dashboard.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_user_dashboard.ForeColor = System.Drawing.Color.White;
            this.btn_user_dashboard.Location = new System.Drawing.Point(12, 268);
            this.btn_user_dashboard.Name = "btn_user_dashboard";
            this.btn_user_dashboard.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btn_user_dashboard.Size = new System.Drawing.Size(168, 50);
            this.btn_user_dashboard.TabIndex = 4;
            this.btn_user_dashboard.Text = "User";
            this.btn_user_dashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_user_dashboard.UseVisualStyleBackColor = true;
            this.btn_user_dashboard.Click += new System.EventHandler(this.btn_user_dashboard_Click);
            // 
            // btn_home_dashboardd
            // 
            this.btn_home_dashboardd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_home_dashboardd.FlatAppearance.BorderSize = 0;
            this.btn_home_dashboardd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_home_dashboardd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home_dashboardd.ForeColor = System.Drawing.Color.White;
            this.btn_home_dashboardd.Location = new System.Drawing.Point(12, 156);
            this.btn_home_dashboardd.Name = "btn_home_dashboardd";
            this.btn_home_dashboardd.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btn_home_dashboardd.Size = new System.Drawing.Size(168, 50);
            this.btn_home_dashboardd.TabIndex = 0;
            this.btn_home_dashboardd.Text = "Home";
            this.btn_home_dashboardd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_home_dashboardd.UseVisualStyleBackColor = true;
            this.btn_home_dashboardd.Click += new System.EventHandler(this.btn_home_dashboardd_Click);
            // 
            // panel_dashboard
            // 
            this.panel_dashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel_dashboard.Location = new System.Drawing.Point(2, 156);
            this.panel_dashboard.Name = "panel_dashboard";
            this.panel_dashboard.Size = new System.Drawing.Size(10, 50);
            this.panel_dashboard.TabIndex = 2;
            // 
            // btn_book_dashboard
            // 
            this.btn_book_dashboard.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_book_dashboard.FlatAppearance.BorderSize = 0;
            this.btn_book_dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_book_dashboard.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_book_dashboard.ForeColor = System.Drawing.Color.White;
            this.btn_book_dashboard.Location = new System.Drawing.Point(12, 212);
            this.btn_book_dashboard.Name = "btn_book_dashboard";
            this.btn_book_dashboard.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btn_book_dashboard.Size = new System.Drawing.Size(168, 50);
            this.btn_book_dashboard.TabIndex = 3;
            this.btn_book_dashboard.Text = "Book";
            this.btn_book_dashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_book_dashboard.UseVisualStyleBackColor = true;
            this.btn_book_dashboard.Click += new System.EventHandler(this.btn_book_dashboard_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel2.Controls.Add(this.btn_close_dashboard);
            this.panel2.Controls.Add(this.lbl_dashboard);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(178, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1022, 41);
            this.panel2.TabIndex = 1;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // btn_close_dashboard
            // 
            this.btn_close_dashboard.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_close_dashboard.BackgroundImage")));
            this.btn_close_dashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_close_dashboard.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_close_dashboard.FlatAppearance.BorderSize = 0;
            this.btn_close_dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close_dashboard.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close_dashboard.ForeColor = System.Drawing.Color.White;
            this.btn_close_dashboard.Location = new System.Drawing.Point(991, 10);
            this.btn_close_dashboard.Name = "btn_close_dashboard";
            this.btn_close_dashboard.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btn_close_dashboard.Size = new System.Drawing.Size(20, 20);
            this.btn_close_dashboard.TabIndex = 9;
            this.btn_close_dashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_close_dashboard.UseVisualStyleBackColor = true;
            this.btn_close_dashboard.Click += new System.EventHandler(this.btn_close_dashboard_Click);
            // 
            // lbl_dashboard
            // 
            this.lbl_dashboard.AutoSize = true;
            this.lbl_dashboard.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dashboard.ForeColor = System.Drawing.Color.White;
            this.lbl_dashboard.Location = new System.Drawing.Point(6, 11);
            this.lbl_dashboard.Name = "lbl_dashboard";
            this.lbl_dashboard.Size = new System.Drawing.Size(89, 20);
            this.lbl_dashboard.TabIndex = 2;
            this.lbl_dashboard.Text = "Dashboard";
            // 
            // adminUC1
            // 
            this.adminUC1.BackColor = System.Drawing.Color.Ivory;
            this.adminUC1.Location = new System.Drawing.Point(178, 41);
            this.adminUC1.Name = "adminUC1";
            this.adminUC1.Size = new System.Drawing.Size(1022, 659);
            this.adminUC1.TabIndex = 6;
            // 
            // issueUC1
            // 
            this.issueUC1.BackColor = System.Drawing.Color.SeaShell;
            this.issueUC1.Location = new System.Drawing.Point(178, 41);
            this.issueUC1.Name = "issueUC1";
            this.issueUC1.Size = new System.Drawing.Size(1022, 659);
            this.issueUC1.TabIndex = 5;
            // 
            // userUC1
            // 
            this.userUC1.BackColor = System.Drawing.Color.GhostWhite;
            this.userUC1.Location = new System.Drawing.Point(178, 41);
            this.userUC1.Name = "userUC1";
            this.userUC1.Size = new System.Drawing.Size(1022, 659);
            this.userUC1.TabIndex = 4;
            // 
            // bookUC1
            // 
            this.bookUC1.BackColor = System.Drawing.Color.FloralWhite;
            this.bookUC1.Location = new System.Drawing.Point(178, 41);
            this.bookUC1.Name = "bookUC1";
            this.bookUC1.Size = new System.Drawing.Size(1022, 659);
            this.bookUC1.TabIndex = 3;
            // 
            // homeUC1
            // 
            this.homeUC1.BackColor = System.Drawing.Color.MintCream;
            this.homeUC1.Location = new System.Drawing.Point(178, 41);
            this.homeUC1.Name = "homeUC1";
            this.homeUC1.Size = new System.Drawing.Size(1022, 659);
            this.homeUC1.TabIndex = 2;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.adminUC1);
            this.Controls.Add(this.issueUC1);
            this.Controls.Add(this.userUC1);
            this.Controls.Add(this.bookUC1);
            this.Controls.Add(this.homeUC1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1200, 700);
            this.MinimumSize = new System.Drawing.Size(1200, 700);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_admin_dashboard;
        private System.Windows.Forms.Button btn_issue_dashboard;
        private System.Windows.Forms.Button btn_user_dashboard;
        private System.Windows.Forms.Button btn_home_dashboardd;
        private System.Windows.Forms.Panel panel_dashboard;
        private System.Windows.Forms.Button btn_book_dashboard;
        private System.Windows.Forms.Button btn_close_dashboard;
        private System.Windows.Forms.Label lbl_dashboard;
        private HomeUC homeUC1;
        private BookUC bookUC1;
        private UserUC userUC1;
        private IssueUC issueUC1;
        private AdminUC adminUC1;
    }
}