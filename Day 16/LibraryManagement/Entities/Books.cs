using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Entities
{
    internal class Books
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string publisherName { get; set; }
        public int numberOfPages { get; set; }
    }
}
