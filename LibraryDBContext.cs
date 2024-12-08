using ConsoleApp41.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp41
{
    internal class LibraryContext : DbContext
    {
        private string _connectionString = "Data Source=C:\\Users\\xiomi\\source\\repos\\ConsoleApp41\\lib1.db";

        public DbSet<Book> Books { get; set; }
        public DbSet<Library> Libraries { get; set; }
        public DbSet<Reader> Readers { get; set; }
        public DbSet<Taken> Takens { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlite(_connectionString);
        }

    }
}
