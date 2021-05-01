using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management.Model
{
    class Users
    {
        public int ID { get; private set; }
        public string User_Name { get; private set; }
        public string Name { get; private set; }
        public int Phone { get; private set; }
        public string Location { get; private set; }
        public string DOB { get; private set; }
        public string Type { get; private set; }

        public Users() { }

        public string AuthenticateUser(string user_name, string password, string type)
        {
            string name = null;
            string query = DatabaseHelper.LoginQuery(user_name, password, type);
            SqlConnection conn = DatabaseHelper.connectDB();
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                name = (string)reader.GetValue(reader.GetOrdinal("name"));
            }
            conn.Close();
            return name;
        }
    }
}
