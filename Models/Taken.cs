﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp41.Models
{
    public class Taken
    {
        public int Id { get; set; }

        public int UserId { get; set; }
        public Reader User { get; set; }

        public int BookId { get; set; }
        public Book Book { get; set; }

        public DateTime BorrowedDate { get; set; }
        public DateTime? ReturnedDate { get; set; }
    }
}
