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
    public partial class HomeUC : UserControl
    {
        public HomeUC()
        {
            InitializeComponent();
            lbl_admin_home.Text = getAllAdmins().ToString();
            lbl_books_home.Text = getAllBooks().ToString();
            lbl_users_home.Text = getAllUsers().ToString();
        }

        private int getAllUsers()
        {
            UserControls userControls = new UserControls();
            List<User> users = userControls.LoadUsers("user");
            int count = 0;
            foreach(User u in users)
            {
                count++;
            }
            return count;
        }

        private int getAllAdmins()
        {
            UserControls userControls = new UserControls();
            List<User> users = userControls.LoadUsers("admin");
            int count = 0;
            foreach (User u in users)
            {
                count++;
            }
            return count;
        }

        private int getAllBooks()
        {
            BookControls bookControls = new BookControls();
            List<Book> books = bookControls.LoadBooks("All");
            int count = 0;
            foreach (Book b in books)
            {
                count++;
            }
            return count;
        }
    }
}
