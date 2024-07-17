using NanoidDotNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class Loan
    {
        public string LoanId { get; set; }
        public Book Book { get; set; }
        public Member Member { get; set; }
        public DateTime LoanDate { get; set; }
        public DateTime ReturnTime { get; set; }

        public Loan(Book book, Member member, DateTime loanDate, DateTime returnTime)
        {
            this.LoanId = Nanoid.Generate(size: 5);
            this.Book = book;
            this.Member = member;
            this.LoanDate = loanDate;
            this.ReturnTime = returnTime;
        }
    }
}
