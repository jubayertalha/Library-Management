using Library_Management.Controls;
using Library_Management.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management.View
{
    public partial class IssueUC : UserControl
    {
        public IssueUC()
        {
            InitializeComponent();
            DisableViews();
            LoadIssueByStatus();
        }

        private void LoadIssueByStatus()
        {
            string status = cb_search_issue.SelectedItem.ToString().Trim();
            IssueControls issueControls = new IssueControls();
            if (status.Equals("Expired"))
            {
                List<Issue> allIssue = issueControls.LoadIssuesByStatus("Expired");
                List<Issue> expiredIssue = new List<Issue>();
                foreach (Issue i in allIssue)
                {
                    if (i.Status.Equals("Expired"))
                    {
                        expiredIssue.Add(i);
                    }
                }
                gv_info_issue.DataSource = expiredIssue;
            }
            else if (status.Equals("Returned"))
            {
                gv_info_issue.DataSource = issueControls.LoadIssuesByStatus(status);
            }
            else
            {
                List<Issue> allIssue = issueControls.LoadIssuesByStatus(status);
                List<Issue> issuedIssue = new List<Issue>();
                foreach (Issue i in allIssue)
                {
                    if (i.Status.Equals("Issued"))
                    {
                        issuedIssue.Add(i);
                    }
                }
                gv_info_issue.DataSource = issuedIssue;
            }
        }

        private void LoadIssueByUser()
        {
            string user_name = tb_user_name_issue.Text.Trim();
            IssueControls issueControls = new IssueControls();
            gv_info_issue.DataSource = issueControls.LoadIssuesByUser(user_name);
        }

        private void btn_search_issue_Click(object sender, EventArgs e)
        {

        }

        private void btn_user_name_enter_issue_Click(object sender, EventArgs e)
        {
            string user_name = tb_user_name_issue.Text.Trim();
            if (isValidString(user_name))
            {
                UserControls userControls = new UserControls();
                User user = userControls.SearchUser(user_name, "user");
                if (user != null)
                {
                    IssueControls issueControls = new IssueControls();
                    List<Issue> issues = issueControls.LoadIssuesByUser(user_name);
                    int issued = 0;
                    int returned = 0;
                    int expired = 0;
                    foreach (Issue i in issues)
                    {
                        if (i.Status.Equals("Issued"))
                        {
                            issued++;
                        }else if (i.Status.Equals("Rerturned"))
                        {
                            returned++;
                        }
                        else
                        {
                            expired++;
                        }
                    }
                    lbl_user_info_issue.Text = "Returned: " + returned + "    Issued: " + issued + "    Expired: " + expired;
                    if (expired == 0)
                    {
                        tb_book_id_issue.Enabled = true;
                        btn_book_enter_issue.Enabled = true;
                        tb_user_name_issue.Enabled = false;
                        btn_user_name_enter_issue.Enabled = false;
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

        private void btn_book_enter_issue_Click(object sender, EventArgs e)
        {
            string sid = tb_book_id_issue.Text.ToString().Trim();
            if (isValidString(sid))
            {
                int id = int.Parse(sid);
                BookControls bookControls = new BookControls();
                Book book = bookControls.SearchBook(id);
                if (book != null)
                {
                    IssueControls issueControls = new IssueControls();
                    List<Issue> allIssue = issueControls.LoadIssuesByStatus("Issued");
                    List<Issue> issuedIssue = new List<Issue>();
                    foreach (Issue i in allIssue)
                    {
                        if (i.Status.Equals("Issued"))
                        {
                            issuedIssue.Add(i);
                        }
                    }
                    int count = 0;
                    foreach(Issue i in issuedIssue)
                    {
                        if(i.BookId == id)
                        {
                            count++;
                        }
                    }
                    int total = book.Stock - count;
                    lbl_book_info_issue.Text = "Total Book Remained: " + total;
                    if (total > 0)
                    {
                        btn_add_issue.Enabled = true;
                        tb_book_id_issue.Enabled = false;
                        btn_book_enter_issue.Enabled = false;
                    }
                }
                else
                {
                    MessageBox.Show("No Book Found.");
                }
            }
            else
            {
                MessageBox.Show("Please Enter Book Id.");
            }
        }

        private void btn_add_issue_Click(object sender, EventArgs e)
        {
            int id = 0;
            string user_name = tb_user_name_issue.Text.Trim();
            int book_id = int.Parse(tb_book_id_issue.Text.Trim());
            string status = cb_status_issue.SelectedItem.ToString().Trim();
            string issue_date = dtp_issue_date_issue.Value.ToString("dd/MM/yyyy").Trim();
            string tobe_return_date = dtp_tobe_return_issue.Value.ToString("dd/MM/yyyy").Trim();
            string return_date = "nill";

            Issue issue = new Issue(id, user_name, book_id, status, issue_date, tobe_return_date, return_date);
            IssueControls issueControls = new IssueControls(issue);
            bool isAdded = issueControls.AddIssue();
            if (isAdded)
            {
                DisableViews();
                cb_search_issue.SelectedIndex = cb_search_issue.FindStringExact("User");
                gv_info_issue.DataSource = issueControls.LoadIssuesByUser(user_name);
                MessageBox.Show("Issue Added.");
            }
            else
            {
                MessageBox.Show("Issue can not be Added.");
            }
        }

        private void btn_edit_issue_Click(object sender, EventArgs e)
        {

        }

        private void btn_delete_issue_Click(object sender, EventArgs e)
        {

        }

        private void btn_clear_issue_Click(object sender, EventArgs e)
        {
            DisableViews();
        }

        private void DisableViews()
        {
            cb_search_issue.Enabled = true;
            tb_user_name_issue.Enabled = true;
            btn_user_name_enter_issue.Enabled = true;
            lbl_user_info_issue.Text = "No Info";
            tb_book_id_issue.Enabled = false;
            tb_book_id_issue.Text = "";
            btn_book_enter_issue.Enabled = false;
            lbl_book_info_issue.Text = "No Info";
            cb_status_issue.Enabled = false;
            dtp_issue_date_issue.Enabled = false;
            dtp_tobe_return_issue.Enabled = false;
            dtp_return_date_issue.Enabled = false;
            btn_add_issue.Enabled = false;
            btn_edit_issue.Enabled = false;
            btn_delete_issue.Enabled = false;
            dtp_issue_date_issue.Value = DateTime.Now;
            dtp_return_date_issue.Value = DateTime.Now;
            dtp_tobe_return_issue.Value = dtp_issue_date_issue.Value.AddDays(25);
            cb_status_issue.SelectedIndex = cb_status_issue.FindStringExact("Issued");
            cb_search_issue.SelectedIndex = cb_search_issue.FindStringExact("Issued");
        }

        private void EnableViews()
        {
            cb_search_issue.Enabled = false;
            tb_user_name_issue.Enabled = false;
            btn_user_name_enter_issue.Enabled = false;
            lbl_user_info_issue.Text = "No Info";
            tb_book_id_issue.Enabled = false;
            btn_book_enter_issue.Enabled = false;
            lbl_book_info_issue.Text = "No Info";
            cb_status_issue.Enabled = true;
            dtp_issue_date_issue.Enabled = true;
            dtp_tobe_return_issue.Enabled = false;
            dtp_return_date_issue.Enabled = false;
            btn_add_issue.Enabled = false;
            btn_edit_issue.Enabled = true;
            btn_delete_issue.Enabled = true;
            dtp_issue_date_issue.Value = DateTime.Now;
            dtp_return_date_issue.Value = DateTime.Now;
            dtp_tobe_return_issue.Value = dtp_issue_date_issue.Value.AddDays(25);
            cb_status_issue.SelectedIndex = cb_status_issue.FindStringExact("Issued");
            cb_search_issue.SelectedIndex = cb_search_issue.FindStringExact("User");
        }

        private bool isValidString(string str)
        {
            return !string.IsNullOrEmpty(str);
        }

        private void cb_search_issue_SelectedIndexChanged(object sender, EventArgs e)
        {
            string type = cb_search_issue.SelectedItem.ToString().Trim();
            if (!type.Equals("User"))
            {
                LoadIssueByStatus();
            }
        }

        private void cb_status_issue_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_status_issue.SelectedItem.ToString().Trim().Equals("Returned"))
            {
                dtp_return_date_issue.Enabled = true;
            }
            else
            {
                dtp_return_date_issue.Enabled = false;
            }
        }

        private void dtp_issue_date_issue_ValueChanged(object sender, EventArgs e)
        {
            dtp_tobe_return_issue.Value = dtp_issue_date_issue.Value.AddDays(25);
        }

        private void tb_search_issue_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tb_book_id_issue_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
