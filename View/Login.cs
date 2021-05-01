using Library_Management.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management.View
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_login_login_Click(object sender, EventArgs e)
        {
            string user_name = tb_userName_login.Text.ToString().Trim();
            string password = tb_pass_login.Text.ToString().Trim();

            if (!string.IsNullOrEmpty(user_name) && !string.IsNullOrEmpty(password))
            {
                Users users = new Users();
                string name = users.AuthenticateUser(user_name, password, "admin");
                if (!string.IsNullOrEmpty(name))
                {
                    DatabaseHelper.name = name;
                    this.Hide();
                    new Dashboard().Show();
                }
                else
                {
                    MessageBox.Show("No user found with this user name and passsword.");
                }
            }
            else
            {
                MessageBox.Show("Please Enter All Values.");
            }
        }

        private void btn_login_masterLogin_Click(object sender, EventArgs e)
        {
            bool isVisible = tb_login_masterPass.Visible;

            if (isVisible)
            {
                string password = tb_login_masterPass.Text.ToString().Trim();

                if (!string.IsNullOrEmpty(password))
                {
                    Users users = new Users();
                    string name = users.AuthenticateUser("master", password, "master");
                    if (!string.IsNullOrEmpty(name))
                    {
                        DatabaseHelper.name = name;
                        this.Hide();
                        new Dashboard().Show();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Master Password.");
                    }
                }
                else
                {
                    MessageBox.Show("Please Enter Master Password.");
                }
            }
            else
            {
                tb_login_masterPass.Visible = true;
                lbl_login_masterPass.Visible = true;
                btn_login_masterLogin.Text = "Submit";
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Application.Exit();
        }
    }
}
