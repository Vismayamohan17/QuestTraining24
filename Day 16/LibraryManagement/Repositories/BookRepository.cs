using LibraryManagement.Data;
using LibraryManagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Repositories
{
    internal class BookRepository
    {
        public GenericResponse<List<Books>> GetAllBooks()
        {
            var Book = Datastore.Book;
            return new GenericResponse<List<Books>>
            {
                Success = true,
                Data = Book,
            };
        }

        public GenericResponse<Books> GetBooksByIdAndName(int id,string Name)
        {
            var Bookbyid = Datastore.Book.FirstOrDefault(x => x.Id == id);
            var Bookbyname = Datastore.Book.FirstOrDefault(x => x.Name == Name);
            if (Bookbyid == null && Bookbyname == null)
            {
                return new GenericResponse<Books>
                {
                    Success = false,
                    Message = "Book not found",
                };
            }

            return new GenericResponse<Books>
            {
                Success = true,
                Data = Bookbyid

            };
        }
    }
}
