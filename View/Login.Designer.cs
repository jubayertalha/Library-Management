
namespace Library_Management.View
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_userName_login = new System.Windows.Forms.TextBox();
            this.tb_pass_login = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_login_login = new System.Windows.Forms.Button();
            this.btn_login_masterLogin = new System.Windows.Forms.Button();
            this.tb_login_masterPass = new System.Windows.Forms.TextBox();
            this.lbl_login_masterPass = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(340, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // tb_userName_login
            // 
            this.tb_userName_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_userName_login.Location = new System.Drawing.Point(346, 155);
            this.tb_userName_login.Name = "tb_userName_login";
            this.tb_userName_login.Size = new System.Drawing.Size(185, 26);
            this.tb_userName_login.TabIndex = 1;
            // 
            // tb_pass_login
            // 
            this.tb_pass_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_pass_login.Location = new System.Drawing.Point(346, 200);
            this.tb_pass_login.Name = "tb_pass_login";
            this.tb_pass_login.Size = new System.Drawing.Size(185, 26);
            this.tb_pass_login.TabIndex = 2;
            this.tb_pass_login.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(243, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "User Name: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(254, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password: ";
            // 
            // btn_login_login
            // 
            this.btn_login_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login_login.Location = new System.Drawing.Point(346, 244);
            this.btn_login_login.Name = "btn_login_login";
            this.btn_login_login.Size = new System.Drawing.Size(116, 34);
            this.btn_login_login.TabIndex = 5;
            this.btn_login_login.Text = "Login";
            this.btn_login_login.UseVisualStyleBackColor = true;
            this.btn_login_login.Click += new System.EventHandler(this.btn_login_login_Click);
            // 
            // btn_login_masterLogin
            // 
            this.btn_login_masterLogin.Location = new System.Drawing.Point(639, 400);
            this.btn_login_masterLogin.Name = "btn_login_masterLogin";
            this.btn_login_masterLogin.Size = new System.Drawing.Size(124, 23);
            this.btn_login_masterLogin.TabIndex = 6;
            this.btn_login_masterLogin.Text = "Master Login";
            this.btn_login_masterLogin.UseVisualStyleBackColor = true;
            this.btn_login_masterLogin.Click += new System.EventHandler(this.btn_login_masterLogin_Click);
            // 
            // tb_login_masterPass
            // 
            this.tb_login_masterPass.Location = new System.Drawing.Point(639, 374);
            this.tb_login_masterPass.Name = "tb_login_masterPass";
            this.tb_login_masterPass.Size = new System.Drawing.Size(124, 20);
            this.tb_login_masterPass.TabIndex = 7;
            this.tb_login_masterPass.UseSystemPasswordChar = true;
            this.tb_login_masterPass.Visible = false;
            // 
            // lbl_login_masterPass
            // 
            this.lbl_login_masterPass.AutoSize = true;
            this.lbl_login_masterPass.Location = new System.Drawing.Point(636, 358);
            this.lbl_login_masterPass.Name = "lbl_login_masterPass";
            this.lbl_login_masterPass.Size = new System.Drawing.Size(88, 13);
            this.lbl_login_masterPass.TabIndex = 8;
            this.lbl_login_masterPass.Text = "Master Password";
            this.lbl_login_masterPass.Visible = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_login_masterPass);
            this.Controls.Add(this.tb_login_masterPass);
            this.Controls.Add(this.btn_login_masterLogin);
            this.Controls.Add(this.btn_login_login);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_pass_login);
            this.Controls.Add(this.tb_userName_login);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_userName_login;
        private System.Windows.Forms.TextBox tb_pass_login;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_login_login;
        private System.Windows.Forms.Button btn_login_masterLogin;
        private System.Windows.Forms.TextBox tb_login_masterPass;
        private System.Windows.Forms.Label lbl_login_masterPass;
    }
}