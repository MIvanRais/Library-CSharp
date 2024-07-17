using NanoidDotNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class Library
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public List<Book> books;
        public List<Member> members;

        public Library(string name, string address, string email, string phoneNumber)
        {
            this.Name = name;
            this.Address = address;
            this.Email = email;
            this.PhoneNumber = phoneNumber;
            this.books = new List<Book>();
            this.members = new List<Member>();
        }

        public void addBook(Book book)
        {
            this.books.Add(book);
        }

        public void removeBook(Book book)
        {
            this.books.Remove(book);
        }

        public void registerMember(Member member)
        {
            this.members.Add(member);
        }

        public void issueLoan(Book book, Member member)
        {
            if (book.checkAvailability())
            {
                Loan loan = new Loan(book, member, DateTime.Now, DateTime.Now.AddDays(6));
                book.updateStock(-1);
                member.borrowBook(loan);
            }
            else
            {
                Console.WriteLine("Book is not available");
            }
        }
    }
}
