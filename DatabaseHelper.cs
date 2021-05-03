using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Library_Management.Model;

namespace Library_Management
{
    class DatabaseHelper
    {
        public static string name = "Master";
        public static SqlConnection connectDB()
        {
            return new SqlConnection(@"Server=DESKTOP-BJDQM5C; Database=library; Integrated Security=true;");
        }

        public static string LoginQuery(string user_name, string password, string type)
        {
            return string.Format(@"select * from users where user_name = '{0}' and password = '{1}' and type = '{2}'", user_name, password, type);
        }

        public static string UserLoadQuery(string type)
        {
            return string.Format(@"select * from users where type = '{0}'", type);
        }

        public static string UserAddQuery(User user)
        {
            return string.Format(@"insert into users values('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", user.User_Name, user.Name, user.Phone, user.Password, user.Location, user.DOB, user.Type);
        }

        public static string UserSearchQuery(string user_name, string type)
        {
            return string.Format(@"select * from users where user_name = '{0}' and type = '{1}'", user_name, type);
        }

        public static string UserDeleteQuery(string user_name, string type)
        {
            return string.Format(@"delete from users where user_name = '{0}' and type = '{1}'", user_name, type);
        }

        public static string UserEditQuery(User user)
        {
            return string.Format(@"update users set name = '{0}', phone = '{1}', password = '{2}', location = '{3}', dob = '{4}', type = '{5}' where user_name = '{6}'", user.Name, user.Phone, user.Password, user.Location, user.DOB, user.Type, user.User_Name);
        }

        public static string BookLoadQuery(string category)
        {
            if (category.Equals("All"))
            {
                return string.Format(@"select * from books");
            }
            else
            {
                return string.Format(@"select * from books where category = '{0}'", category);
            }
            
        }

        public static string BookAddQuery(Book book)
        {
            return string.Format(@"insert into books values('{0}','{1}','{2}', {3})", book.Name, book.Author, book.Category, book.Stock);
        }

        public static string BookSearchQuery(int id)
        {
            return string.Format(@"select * from books where id = {0}", id);
        }

        public static string BookDeleteQuery(int id)
        {
            return string.Format(@"delete from books where id = {0}", id);
        }

        public static string BookEditQuery(Book book)
        {
            return string.Format(@"update books set name = '{0}', author = '{1}', category = '{2}', stock = {3} where id = {4}", book.Name, book.Author, book.Category, book.Stock, book.Id);
        }

        public static string IssueLoadByStatusQuery(string status)
        {
            return string.Format(@"select * from issues where status = '{0}'", status);
        }

        public static string IssueLoadByUserQuery(string user_name)
        {
            return string.Format(@"select * from issues where user_name = '{0}'", user_name);
        }

        public static string IssueAddQuery(Issue issue)
        {
            return string.Format(@"insert into issues values('{0}',{1},'{2}','{3}','{4}','{5}')", issue.UserName, issue.BookId, issue.Status, issue.IssueDate, issue.TobeRetunDate, issue.ReturnDate);
        }
    }
}
