using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management.Model
{
    class User
    {
        public string User_Name { get; private set; }
        public string Name { get; private set; }
        public int Phone { get; private set; }
        public string Location { get; private set; }
        public string DOB { get; private set; }
        public string Type { get; private set; }
        public string Password { get; private set; }

        public User() { }

        public User(string user_Name, string name, int phone, string location, string dOB, string type, string password)
        {
            User_Name = user_Name;
            Name = name;
            Phone = phone;
            Location = location;
            DOB = dOB;
            Type = type;
            Password = password;
        }
    }
}
