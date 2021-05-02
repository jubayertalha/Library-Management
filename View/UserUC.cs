using Library_Management.Controls;
using Library_Management.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management.View
{
    public partial class UserUC : UserControl
    {
        public UserUC()
        {
            InitializeComponent();
            LoadUsers();
        }

        private void LoadUsers()
        {
            UserControls userControls = new UserControls();
            gv_info_user.DataSource = userControls.LoadUsers("user");
            tb_userName_user.Text = "";
            tb_name_user.Text = "";
            tb_phone_user.Text = "";
            tb_location_user.Text = "";
            tb_pass_user.Text = "";
            dtp_dob_user.Value = DateTime.Now;
            tb_search_user.Text = "";
        }

        private void SearchUser(string user_name)
        {
            UserControls userControls = new UserControls();
            User user = userControls.SearchUser(user_name, "user");
            if (user != null)
            {
                tb_userName_user.Text = user.User_Name;
                tb_name_user.Text = user.Name;
                tb_phone_user.Text = Convert.ToString(user.Phone);
                tb_location_user.Text = user.Location;
                tb_pass_user.Text = user.Password;
                dtp_dob_user.Value = DateTime.ParseExact(user.DOB, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            }
            else
            {
                MessageBox.Show("No User Found.");
            }
        }

        private void btn_search_user_Click(object sender, EventArgs e)
        {
            string user_name = tb_search_user.Text.ToString().Trim();
            if (isValidString(user_name))
            {
                SearchUser(user_name);
            }
            else
            {
                MessageBox.Show("Please Enter User Name.");
            }
        }

        private void gv_info_user_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string user_name = gv_info_user.Rows[e.RowIndex].Cells[0].Value.ToString();
            tb_search_user.Text = user_name;
            SearchUser(user_name);
        }

        private void btn_add_user_Click(object sender, EventArgs e)
        {
            string user_name = tb_userName_user.Text.ToString().Trim();
            string name = tb_name_user.Text.ToString().Trim();
            string sphone = tb_phone_user.Text.ToString().Trim();
            string location = tb_location_user.Text.ToString().Trim();
            string dob = dtp_dob_user.Value.ToString("dd/MM/yyyy").Trim();
            string password = tb_pass_user.Text.ToString().Trim();

            if (isValidString(user_name) && isValidString(name) && isValidString(location) && isValidString(password) && isValidString(sphone))
            {
                int phone = int.Parse(sphone);
                UserControls userControls = new UserControls();
                User user = userControls.SearchUser(user_name, "user");
                if (user == null)
                {
                    user = new User(user_name, name, phone, location, dob, "user", password);
                    userControls = new UserControls(user);
                    bool isAdded = userControls.AddUser();
                    if (isAdded)
                    {
                        LoadUsers();
                        MessageBox.Show("User Added.");
                    }
                    else
                    {
                        MessageBox.Show("User can not be Added.");
                    }
                }
                else
                {
                    MessageBox.Show("User Already Exists.");
                }
            }
            else
            {
                MessageBox.Show("Please Enter All Info.");
            }
        }

        private void btn_edit_user_Click(object sender, EventArgs e)
        {
            string user_name = tb_userName_user.Text.ToString().Trim();
            string name = tb_name_user.Text.ToString().Trim();
            string sphone = tb_phone_user.Text.ToString().Trim();
            string location = tb_location_user.Text.ToString().Trim();
            string dob = dtp_dob_user.Value.ToString("dd/MM/yyyy").Trim();
            string password = tb_pass_user.Text.ToString().Trim();

            if (isValidString(user_name) && isValidString(name) && isValidString(location) && isValidString(password) && isValidString(sphone))
            {
                int phone = int.Parse(sphone);
                UserControls userControls = new UserControls();
                User user = userControls.SearchUser(user_name, "user");
                if (user != null)
                {
                    user = new User(user_name, name, phone, location, dob, "user", password);
                    userControls = new UserControls(user);
                    bool isAdded = userControls.EditUser();
                    if (isAdded)
                    {
                        LoadUsers();
                        MessageBox.Show("User Edited.");
                    }
                    else
                    {
                        MessageBox.Show("User can not be Edited.");
                    }
                }
                else
                {
                    MessageBox.Show("User Doesn't Exist.");
                }
            }
            else
            {
                MessageBox.Show("Please Enter All Info.");
            }
        }

        private void btn_delete_user_Click(object sender, EventArgs e)
        {
            string user_name = tb_userName_user.Text.ToString().Trim();
            UserControls userControls = new UserControls();
            if (isValidString(user_name))
            {
                User user = userControls.SearchUser(user_name, "user");
                if (user != null)
                {
                    bool isDeleted = userControls.DeleteUser(user_name, "user");
                    if (isDeleted)
                    {
                        LoadUsers();
                        MessageBox.Show("User Deleted.");
                    }
                    else
                    {
                        MessageBox.Show("User can not be Deleted.");
                    }
                }
                else
                {
                    MessageBox.Show("User Doesn't Exist.");
                }
            }
            else
            {
                MessageBox.Show("Enter User Name.");
            }
        }

        private bool isValidString(string str)
        {
            return !string.IsNullOrEmpty(str);
        }

        private void tb_phone_user_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
