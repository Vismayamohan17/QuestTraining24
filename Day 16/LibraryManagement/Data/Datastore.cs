using LibraryManagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Data
{
    internal static class Datastore
    {
        public static List<Members> Member;
        public static List<Books> Book;

        static Datastore()
        {
            Member = new List<Members>()
            {
                new Members{Id=1, Name="Member1",email="member1@gmail.com"},
                new Members{Id=2, Name="Member2",email="member2@gmail.com"},
                new Members{Id=3, Name="Member3",email="member3@gmail.com"}
            };

            Book = new List<Books>()
            {
                new Books{Id=1,Name="Book 1", publisherName="abc",numberOfPages=200},
                new Books{Id=2,Name="Book 2", publisherName="pqr",numberOfPages=150},
                new Books{Id=3,Name="Book 3", publisherName="xyz",numberOfPages=250}
            };
        }
    }
}
