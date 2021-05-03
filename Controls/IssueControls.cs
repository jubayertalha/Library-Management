using Library_Management.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management.Controls
{
    class IssueControls
    {
        public Issue issue { get; private set; }

        public IssueControls()
        {
        }

        public IssueControls(Issue issue)
        {
            this.issue = issue;
        }

        public List<Issue> LoadIssuesByStatus(string status)
        {
            List<Issue> issues = new List<Issue>();
            string query = DatabaseHelper.IssueLoadByStatusQuery(status);
            SqlConnection conn = DatabaseHelper.connectDB();
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int id = int.Parse(reader.GetValue(reader.GetOrdinal("id")).ToString());
                string user_name = (string)reader.GetValue(reader.GetOrdinal("user_name"));
                int book_id = int.Parse(reader.GetValue(reader.GetOrdinal("book_id")).ToString());
                string statuss = (string)reader.GetValue(reader.GetOrdinal("status"));
                string issue_date = (string)reader.GetValue(reader.GetOrdinal("issue_date"));
                string tobe_return_date = (string)reader.GetValue(reader.GetOrdinal("tobe_return_date"));
                string return_date = (string)reader.GetValue(reader.GetOrdinal("return_date"));

                statuss = GetStatus(tobe_return_date, statuss);

                issue = new Issue(id,user_name,book_id,statuss,issue_date,tobe_return_date,return_date);
                issues.Add(issue);
            }
            conn.Close();
            return issues;
        }

        public List<Issue> LoadIssuesByUser(string user_name)
        {
            List<Issue> issues = new List<Issue>();
            string query = DatabaseHelper.IssueLoadByUserQuery(user_name);
            SqlConnection conn = DatabaseHelper.connectDB();
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int id = int.Parse(reader.GetValue(reader.GetOrdinal("id")).ToString());
                string user_namee = (string)reader.GetValue(reader.GetOrdinal("user_name"));
                int book_id = int.Parse(reader.GetValue(reader.GetOrdinal("book_id")).ToString());
                string statuss = (string)reader.GetValue(reader.GetOrdinal("status"));
                string issue_date = (string)reader.GetValue(reader.GetOrdinal("issue_date"));
                string tobe_return_date = (string)reader.GetValue(reader.GetOrdinal("tobe_return_date"));
                string return_date = (string)reader.GetValue(reader.GetOrdinal("return_date"));

                statuss = GetStatus(tobe_return_date, statuss);

                issue = new Issue(id, user_namee, book_id, statuss, issue_date, tobe_return_date, return_date);
                issues.Add(issue);
            }
            conn.Close();
            return issues;
        }

        public string GetStatus(string tobe_return_date, string status)
        {
            DateTime tobe = DateTime.ParseExact(tobe_return_date.Trim(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            if (!status.Equals("Returned"))
            {
                if (DateTime.Compare(DateTime.Now, tobe) > 0)
                {
                    status = "Expired";
                }
            }
            return status;
        }

        public Issue SearchIssue(int id)
        {
            string query = DatabaseHelper.IssueSearchQuery(id);
            SqlConnection conn = DatabaseHelper.connectDB();
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int idd = int.Parse(reader.GetValue(reader.GetOrdinal("id")).ToString());
                string user_namee = (string)reader.GetValue(reader.GetOrdinal("user_name"));
                int book_id = int.Parse(reader.GetValue(reader.GetOrdinal("book_id")).ToString());
                string statuss = (string)reader.GetValue(reader.GetOrdinal("status"));
                string issue_date = (string)reader.GetValue(reader.GetOrdinal("issue_date"));
                string tobe_return_date = (string)reader.GetValue(reader.GetOrdinal("tobe_return_date"));
                string return_date = (string)reader.GetValue(reader.GetOrdinal("return_date"));

                statuss = GetStatus(tobe_return_date, statuss);

                issue = new Issue(idd, user_namee, book_id, statuss, issue_date, tobe_return_date, return_date);
            }
            conn.Close();
            return issue;
        }

        public bool AddIssue()
        {
            string query = DatabaseHelper.IssueAddQuery(issue);
            SqlConnection conn = DatabaseHelper.connectDB();
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            return r == 1;
        }

        public bool EditIssue()
        {
            string query = DatabaseHelper.IssueEditQuery(issue);
            SqlConnection conn = DatabaseHelper.connectDB();
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            return r == 1;
        }

        public bool DeleteIssue(int id)
        {
            string query = DatabaseHelper.IssueDeleteQuery(id);
            SqlConnection conn = DatabaseHelper.connectDB();
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            return r == 1;
        }
    }
}
