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
    public partial class BookUC : UserControl
    {
        public BookUC()
        {
            InitializeComponent();
            cb_search_book.SelectedIndex = cb_search_book.FindStringExact("All");
            ClearViews();
        }

        private void LoadBooks()
        {
            BookControls bookControls = new BookControls();
            gv_info_book.DataSource = bookControls.LoadBooks(cb_search_book.SelectedItem.ToString().Trim());
        }

        private void cb_search_book_SelectedIndexChanged(object sender, EventArgs e)
        {
            gb_info_book.Text = " " + cb_search_book.SelectedItem.ToString().Trim() + " Book Info ";
            LoadBooks();
        }

        private void SearchBook(int id)
        {
            BookControls bookControls = new BookControls();
            Book book = bookControls.SearchBook(id);
            if (book != null)
            {
                tb_id_book.Text = book.Id.ToString().Trim();
                tb_name_book.Text = book.Name;
                tb_author_book.Text = book.Author;
                cb_category_book.SelectedIndex = cb_category_book.FindStringExact(book.Category.Trim());
                tb_stock_book.Text = book.Stock.ToString().Trim();
            }
            else
            {
                MessageBox.Show("No Book Found.");
            }
        }

        private void btn_search_book_Click(object sender, EventArgs e)
        {
            string sid = tb_search_book.Text.ToString().Trim();
            if (isValidString(sid))
            {
                int id = int.Parse(sid);
                SearchBook(id);
            }
            else
            {
                MessageBox.Show("Please Enter Book Id.");
            }
        }

        private void gv_info_book_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = int.Parse(gv_info_book.Rows[e.RowIndex].Cells[0].Value.ToString().Trim());
            tb_search_book.Text = id.ToString().Trim();
            SearchBook(id);
        }

        private void btn_add_book_Click(object sender, EventArgs e)
        {
            string sid = tb_id_book.Text.Trim();
            string name = tb_name_book.Text.ToString().Trim();
            string author = tb_author_book.Text.ToString().Trim();
            string category = cb_category_book.SelectedItem.ToString().Trim();
            string sstock = tb_stock_book.Text.ToString().Trim();

            if (category.Equals("Select"))
            {
                category = "";
            }

            if (!isValidString(sid))
            {
                sid = "0";
            }

            if (isValidString(sid) && isValidString(name) && isValidString(author) && isValidString(category) && isValidString(sstock))
            {
                int id = int.Parse(sid);
                int stock = int.Parse(sstock);
                BookControls bookControls = new BookControls();
                Book book = bookControls.SearchBook(id);
                if (book == null)
                {
                    book = new Book(id,name,author,category,stock);
                    bookControls = new BookControls(book);
                    bool isAdded = bookControls.AddUser();
                    if (isAdded)
                    {
                        if (cb_search_book.SelectedIndex == cb_search_book.FindStringExact(book.Category.Trim()))
                        {
                            LoadBooks();
                        }
                        else
                        {
                            cb_search_book.SelectedIndex = cb_search_book.FindStringExact(book.Category.Trim());
                        }
                        ClearViews();
                        MessageBox.Show("Book Added.");
                    }
                    else
                    {
                        MessageBox.Show("Book can not be Added.");
                    }
                }
                else
                {
                    MessageBox.Show("Book Already Exists.");
                }
            }
            else
            {
                MessageBox.Show("Please Enter All Info.");
            }
        }

        private void btn_edit_book_Click(object sender, EventArgs e)
        {
            string sid = tb_id_book.Text.Trim();
            string name = tb_name_book.Text.ToString().Trim();
            string author = tb_author_book.Text.ToString().Trim();
            string category = cb_category_book.SelectedItem.ToString().Trim();
            string sstock = tb_stock_book.Text.ToString().Trim();

            if (category.Equals("Select"))
            {
                category = "";
            }

            if (!isValidString(sid))
            {
                sid = "0";
            }

            if (isValidString(sid) && isValidString(name) && isValidString(author) && isValidString(category) && isValidString(sstock))
            {
                int id = int.Parse(sid);
                int stock = int.Parse(sstock);
                BookControls bookControls = new BookControls();
                Book book = bookControls.SearchBook(id);
                if (book != null)
                {
                    book = new Book(id, name, author, category, stock);
                    bookControls = new BookControls(book);
                    bool isEdited = bookControls.EditBook();
                    if (isEdited)
                    {
                        if (cb_search_book.SelectedIndex == cb_search_book.FindStringExact(book.Category.Trim()))
                        {
                            LoadBooks();
                        }
                        else
                        {
                            cb_search_book.SelectedIndex = cb_search_book.FindStringExact(book.Category.Trim());
                        }
                        ClearViews();
                        MessageBox.Show("Book Edited.");
                    }
                    else
                    {
                        MessageBox.Show("Book can not be Edited.");
                    }
                }
                else
                {
                    MessageBox.Show("Book Doesn't Exist.");
                }
            }
            else
            {
                MessageBox.Show("Please Enter All Info.");
            }
        }

        private void btn_delete_book_Click(object sender, EventArgs e)
        {
            string sid = tb_id_book.Text.ToString().Trim();
            BookControls bookControls = new BookControls();
            if (isValidString(sid))
            {
                int id = int.Parse(sid);
                Book book = bookControls.SearchBook(id);
                if (book != null)
                {
                    bool isDeleted = bookControls.DeleteBook(id);
                    if (isDeleted)
                    {
                        if(cb_search_book.SelectedIndex == cb_search_book.FindStringExact(book.Category.Trim()))
                        {
                            LoadBooks();
                        }
                        else
                        {
                            cb_search_book.SelectedIndex = cb_search_book.FindStringExact(book.Category.Trim());
                        }
                        ClearViews();
                        MessageBox.Show("Book Deleted.");
                    }
                    else
                    {
                        MessageBox.Show("Book can not be Deleted.");
                    }
                }
                else
                {
                    MessageBox.Show("Book Doesn't Exist.");
                }
            }
            else
            {
                MessageBox.Show("Enter Book Id.");
            }
        }

        private void ClearViews()
        {
            tb_id_book.Text = "";
            tb_name_book.Text = "";
            tb_author_book.Text = "";
            cb_category_book.SelectedIndex = cb_category_book.FindStringExact("Select");
            tb_stock_book.Text = "";
        }

        private void btn_clear_book_Click(object sender, EventArgs e)
        {
            ClearViews();
        }

        private void tb_stock_book_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tb_search_book_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private bool isValidString(string str)
        {
            return !string.IsNullOrEmpty(str);
        }
    }
}
