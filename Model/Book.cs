using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management.Model
{
    class Book
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Author { get; private set; }
        public string Category { get; private set; }
        public int Stock { get; private set; }

        public Book()
        {
        }

        public Book(int id, string name, string author, string category, int stock)
        {
            Id = id;
            Name = name;
            Author = author;
            Category = category;
            Stock = stock;
        }
    }
}
