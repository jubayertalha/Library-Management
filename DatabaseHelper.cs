using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Library_Management
{
    class DatabaseHelper
    {
        public static string name = "";
        public static SqlConnection connectDB()
        {
            return new SqlConnection(@"Server=DESKTOP-BJDQM5C; Database=library; Integrated Security=true;");
        }

        public static string LoginQuery(string user_name, string password, string type)
        {
            return string.Format(@"select * from users where user_name = '{0}' and password = '{1}' and type = '{2}'", user_name, password, type);
        }
    }
}
