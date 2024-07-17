using NanoidDotNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class Member
    {
        public string MemberId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public List<Loan> loans;

        public Member(string name, string email, string phoneNumber)
        {
            this.MemberId = Nanoid.Generate(size: 5);
            this.Name = name;
            this.Email = email;
            this.PhoneNumber = phoneNumber;
            this.loans = new List<Loan>();
        }

        public void borrowBook(Loan loan)
        {
            this.loans.Add(loan);
        }

        public void ReturnBook(Loan loan)
        {
            this.loans.Remove(loan);
            loan.Book.updateStock(1);
        }
    }
}
