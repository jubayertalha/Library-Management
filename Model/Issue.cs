using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management.Model
{
    class Issue
    {
        public int Id { get; private set; }
        public string UserName { get; private set; }
        public int BookId { get; private set; }
        public string Status { get; private set; }
        public string IssueDate { get; private set; }
        public string TobeRetunDate { get; private set; }
        public string ReturnDate { get; private set; }

        public Issue()
        {
        }

        public Issue(int id, string userName, int bookId, string status, string issueDate, string tobeRetunDate, string returnDate)
        {
            Id = id;
            UserName = userName;
            BookId = bookId;
            Status = status;
            IssueDate = issueDate;
            TobeRetunDate = tobeRetunDate;
            ReturnDate = returnDate;
        }
    }
}
