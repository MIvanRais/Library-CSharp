using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library("Perpustakaan Nasional RI", "Jl. Medan Merdeka Selatan No.11,Jakarta 10110", "persuratan@perpusnas.go.id", "085717147303");

            Book book1 = new Book("Bumi Manusia", new List<string> { "Pramoedya" }, 10);
            Book book2 = new Book("Laskar Pelangi", new List<string> { "Andrea Hirata" }, 5);

            library.addBook(book1);
            library.addBook(book2);
            //Console.WriteLine(library.books[0].Title);
            //Console.WriteLine(library.books[1].Title);

            Member member1 = new Member("Jhon", "jhon@gmail.com", "0958371321");
            Member member2 = new Member("Dave", "dave@gmail.com", "0218674329");
            Member member3 = new Member("Rangga", "rangga@gmail.com", "0878365271");
            Member member4 = new Member("Nay", "nay@gmail.com", "04583652127");
            Member member5 = new Member("Raniya", "raniya@gmail.com", "04583658361");
            Member member6 = new Member("Kanaya", "kanaya@gmail.com", "869504321");

            library.registerMember(member1);
            library.registerMember(member2);
            library.registerMember(member3);
            library.registerMember(member4);
            library.registerMember(member5);

            //Console.WriteLine(library.members);
            //Console.WriteLine(library.members.Count);


            library.issueLoan(book1, member1);
            library.issueLoan(book2, member1);
            //Console.WriteLine(member1.loans[0].Book.Title);
            library.issueLoan(book2, member2);
            library.issueLoan(book2, member3);
            library.issueLoan(book2, member4);
            library.issueLoan(book2, member5);
            //Console.WriteLine(book2.checkAvailability());
            library.issueLoan(book2, member6); // book is not available

            member1.ReturnBook(member2.loans[0]);
            Console.WriteLine(member2.loans.Count);
            Console.WriteLine(book2.checkAvailability());
        }
    }
}
