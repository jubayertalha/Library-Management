using Library_Management.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management.Controls
{
    class UserControls
    {
        public User user { get; private set; }

        public UserControls() {
            
        }

        public UserControls(User user)
        {
            this.user = user;
        }

        public List<User> LoadUsers(string type)
        {
            List<User> users = new List<User>();
            string query = DatabaseHelper.UserLoadQuery(type);
            SqlConnection conn = DatabaseHelper.connectDB();
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string user_name = (string)reader.GetValue(reader.GetOrdinal("user_name"));
                string name = (string)reader.GetValue(reader.GetOrdinal("name"));
                int phone = int.Parse(reader.GetValue(reader.GetOrdinal("phone")).ToString());
                string password = (string)reader.GetValue(reader.GetOrdinal("password"));
                string location = (string)reader.GetValue(reader.GetOrdinal("location"));
                string dob = (string)reader.GetValue(reader.GetOrdinal("dob"));
                string typee = (string)reader.GetValue(reader.GetOrdinal("type"));

                user = new User(user_name, name, phone, location, dob, typee, password);
                users.Add(user);
            }
            conn.Close();
            return users;
        }

        public bool AddUser()
        {
            string query = DatabaseHelper.UserAddQuery(user);
            SqlConnection conn = DatabaseHelper.connectDB();
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            return r == 1;
        }

        public User SearchUser(string user_name, string type)
        {
            string query = DatabaseHelper.UserSearchQuery(user_name, type);
            SqlConnection conn = DatabaseHelper.connectDB();
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string name = (string)reader.GetValue(reader.GetOrdinal("name"));
                int phone = int.Parse(reader.GetValue(reader.GetOrdinal("phone")).ToString());
                string password = (string)reader.GetValue(reader.GetOrdinal("password"));
                string location = (string)reader.GetValue(reader.GetOrdinal("location"));
                string dob = (string)reader.GetValue(reader.GetOrdinal("dob"));

                user = new User(user_name, name, phone, location, dob, type, password);
            }
            conn.Close();
            return user;
        }

        public bool DeleteUser(string user_name, string type)
        {
            string query = DatabaseHelper.UserDeleteQuery(user_name, type);
            SqlConnection conn = DatabaseHelper.connectDB();
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            return (r == 1);
        }

        public bool EditUser()
        {
            string query = DatabaseHelper.UserEditQuery(user);
            SqlConnection conn = DatabaseHelper.connectDB();
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            return (r == 1);
        }

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
