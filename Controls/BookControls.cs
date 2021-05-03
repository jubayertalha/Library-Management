using Library_Management.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management.Controls
{
    class BookControls
    {
        public Book book { get; private set; }

        public BookControls()
        {

        }

        public BookControls(Book book)
        {
            this.book = book;
        }

        public List<Book> LoadBooks(string category)
        {
            List<Book> books = new List<Book>();
            string query = DatabaseHelper.BookLoadQuery(category);
            SqlConnection conn = DatabaseHelper.connectDB();
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int id = int.Parse(reader.GetValue(reader.GetOrdinal("id")).ToString().Trim());
                string name = (string)reader.GetValue(reader.GetOrdinal("name"));
                string author = (string)reader.GetValue(reader.GetOrdinal("author"));
                string categoryy = (string)reader.GetValue(reader.GetOrdinal("category"));
                int stock = int.Parse(reader.GetValue(reader.GetOrdinal("stock")).ToString().Trim());

                book = new Book(id,name,author,categoryy,stock);
                books.Add(book);
            }
            conn.Close();
            return books;
        }

        public bool AddUser()
        {
            string query = DatabaseHelper.BookAddQuery(book);
            SqlConnection conn = DatabaseHelper.connectDB();
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            return r == 1;
        }

        public Book SearchBook(int id)
        {
            string query = DatabaseHelper.BookSearchQuery(id);
            SqlConnection conn = DatabaseHelper.connectDB();
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int idd = int.Parse(reader.GetValue(reader.GetOrdinal("id")).ToString().Trim());
                string name = (string)reader.GetValue(reader.GetOrdinal("name"));
                string author = (string)reader.GetValue(reader.GetOrdinal("author"));
                string categoryy = (string)reader.GetValue(reader.GetOrdinal("category"));
                int stock = int.Parse(reader.GetValue(reader.GetOrdinal("stock")).ToString().Trim());

                book = new Book(idd, name, author, categoryy, stock);
            }
            conn.Close();
            return book;
        }

        public bool DeleteBook(int id)
        {
            string query = DatabaseHelper.BookDeleteQuery(id);
            SqlConnection conn = DatabaseHelper.connectDB();
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            return (r == 1);
        }

        public bool EditBook()
        {
            string query = DatabaseHelper.BookEditQuery(book);
            SqlConnection conn = DatabaseHelper.connectDB();
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            return (r == 1);
        }
    }
}
