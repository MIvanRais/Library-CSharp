using NanoidDotNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class Book
    {
        public string BookId { get; set; }
        public string Title { get; set; }
        public string Isbn { get; set; }
        public int Stock { get; set; }
        public List<string> author;

        public Book(string title, List<string> author, int stock)
        {
            this.BookId = Nanoid.Generate(size: 5);
            this.Title = title;
            this.author = author;
            this.Isbn = Nanoid.Generate(size: 5);
            this.Stock = stock;
        }

        public void updateStock(int stock)
        {
            this.Stock += stock;
        }

        public bool checkAvailability()
        {
            return this.Stock > 0;
        }
    }
}
