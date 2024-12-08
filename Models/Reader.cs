using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp41.Models
{
    public class Reader
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Book> BorrowedBooks { get; set; }

        public ICollection<Taken> Borrowings { get; set; }
    }
}
