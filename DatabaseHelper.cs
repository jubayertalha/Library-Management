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

        public static string UserLoadQuery()
        {
            return string.Format(@"select * from users");
        }

        public static string UserAddQuery(User user)
        {
            return string.Format(@"insert into users values('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", user.User_Name,user.Name,user.Phone,user.Password,user.Location,user.DOB,user.Type);
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
    }
}
