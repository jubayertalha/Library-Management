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
    public partial class AdminUC : UserControl
    {
        public AdminUC()
        {
            InitializeComponent();
            LoadUsers();
        }

        private void LoadUsers()
        {
            UserControls userControls = new UserControls();
            gv_info_admin.DataSource = userControls.LoadUsers();
            tb_userName_admin.Text = "";
            tb_name_admin.Text = "";
            tb_phone_admin.Text = "";
            tb_location_admin.Text = "";
            tb_pass_admin.Text = "";
            dtp_dob_admin.Value = DateTime.Now;
            tb_search_admin.Text = "";
        }

        private void btn_search_admin_Click(object sender, EventArgs e)
        {
            string user_name = tb_search_admin.Text.ToString().Trim();
            if (isValidString(user_name))
            {
                SearchUser(user_name);
            }
            else
            {
                MessageBox.Show("Please Enter User Name.");
            }
        }

        private void SearchUser(string user_name)
        {
            UserControls userControls = new UserControls();
            User user = userControls.SearchUser(user_name, "admin");
            if (user != null)
            {
                tb_userName_admin.Text = user.User_Name;
                tb_name_admin.Text = user.Name;
                tb_phone_admin.Text = Convert.ToString(user.Phone);
                tb_location_admin.Text = user.Location;
                tb_pass_admin.Text = user.Password;
                dtp_dob_admin.Value = DateTime.ParseExact(user.DOB, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            }
            else
            {
                MessageBox.Show("No User Found.");
            }
        }

        private void btn_add_admin_Click(object sender, EventArgs e)
        {
            string user_name = tb_userName_admin.Text.ToString().Trim();
            string name = tb_name_admin.Text.ToString().Trim();
            string sphone = tb_phone_admin.Text.ToString().Trim();
            string location = tb_location_admin.Text.ToString().Trim();
            string dob = dtp_dob_admin.Value.ToString("dd/MM/yyyy").Trim();
            string password = tb_pass_admin.Text.ToString().Trim();

            if (isValidString(user_name) && isValidString(name) && isValidString(location) && isValidString(password) && isValidString(sphone))
            {
                int phone = int.Parse(sphone);
                UserControls userControls = new UserControls();
                User user = userControls.SearchUser(user_name, "admin");
                if (user == null)
                {
                    user = new User(user_name, name, phone, location, dob, "admin", password);
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

        private void gv_info_admin_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string user_name = gv_info_admin.Rows[e.RowIndex].Cells[0].Value.ToString();
            tb_search_admin.Text = user_name;
            SearchUser(user_name);
        }

        private void btn_delete_admin_Click(object sender, EventArgs e)
        {
            string user_name = tb_userName_admin.Text.ToString().Trim();
            UserControls userControls = new UserControls();
            if (isValidString(user_name))
            {
                if (!user_name.Equals("master"))
                {
                    User user = userControls.SearchUser(user_name, "admin");
                    if (user != null)
                    {
                        bool isDeleted = userControls.DeleteUser(user_name, "admin");
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
                    MessageBox.Show("Master can not be Delted.");
                }
            }
            else
            {
                MessageBox.Show("Enter User Name.");
            }
        }

        private void btn_edit_admin_Click(object sender, EventArgs e)
        {
            string user_name = tb_userName_admin.Text.ToString().Trim();
            string name = tb_name_admin.Text.ToString().Trim();
            string sphone = tb_phone_admin.Text.ToString().Trim();
            string location = tb_location_admin.Text.ToString().Trim();
            string dob = dtp_dob_admin.Value.ToString("dd/MM/yyyy").Trim();
            string password = tb_pass_admin.Text.ToString().Trim();

            if (isValidString(user_name) && isValidString(name) && isValidString(location) && isValidString(password) && isValidString(sphone))
            {
                int phone = int.Parse(sphone);
                UserControls userControls = new UserControls();
                User user = userControls.SearchUser(user_name, "admin");
                if (user != null)
                {
                    user = new User(user_name, name, phone, location, dob, "admin", password);
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

        private bool isValidString(string str)
        {
            return !string.IsNullOrEmpty(str);
        }

        private void tb_phone_admin_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
