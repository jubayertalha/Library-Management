using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management.View
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            lbl_dashboard.Text = "Dashboard || " + DatabaseHelper.name;
            if (!DatabaseHelper.name.Equals("Master"))
            {
                btn_admin_dashboard.Visible = false;
            }
            panel_dashboard.Height = btn_home_dashboardd.Height;
            panel_dashboard.Top = btn_home_dashboardd.Top;
            homeUC1.BringToFront();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Application.Exit();
        }

        private void btn_close_dashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }

        private void btn_home_dashboardd_Click(object sender, EventArgs e)
        {
            panel_dashboard.Height = btn_home_dashboardd.Height;
            panel_dashboard.Top = btn_home_dashboardd.Top;
            homeUC1.BringToFront();
        }

        private void btn_book_dashboard_Click(object sender, EventArgs e)
        {
            panel_dashboard.Height = btn_book_dashboard.Height;
            panel_dashboard.Top = btn_book_dashboard.Top;
            bookUC1.BringToFront();
        }

        private void btn_user_dashboard_Click(object sender, EventArgs e)
        {
            panel_dashboard.Height = btn_user_dashboard.Height;
            panel_dashboard.Top = btn_user_dashboard.Top;
            userUC1.BringToFront();
        }

        private void btn_issue_dashboard_Click(object sender, EventArgs e)
        {
            panel_dashboard.Height = btn_issue_dashboard.Height;
            panel_dashboard.Top = btn_issue_dashboard.Top;
            issueUC1.BringToFront();
        }

        private void btn_admin_dashboard_Click(object sender, EventArgs e)
        {
            panel_dashboard.Height = btn_admin_dashboard.Height;
            panel_dashboard.Top = btn_admin_dashboard.Top;
            adminUC1.BringToFront();
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xF012, 0);
        }
    }
}
