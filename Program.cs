using Microsoft.EntityFrameworkCore;
namespace ConsoleApp41
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new LibraryContext())
            {
                //context.Database.Migrate();
                //not taken
                var availableBooks = context.Books
                .Where(b => !context.Takens.Any(t => t.BookId == b.Id && t.ReturnedDate == null))
                .Select(b => new { b.Title, b.Author, b.Genre })
                .ToList();

                foreach (var book in availableBooks)
                {
                    Console.WriteLine($"{book.Title} by {book.Author} ({book.Genre})");
                }

                    Console.WriteLine();
                //history of reader
                int readerId = 1; 

                var readerHistory = context.Takens
                    .Where(t => t.UserId == readerId)
                    .Select(t => new
                    {
                        t.Book.Title,
                        t.BorrowedDate,
                        t.ReturnedDate
                    })
                    .ToList();

                foreach (var record in readerHistory)
                {
                    Console.WriteLine($"Book: {record.Title}, Borrowed: {record.BorrowedDate}, Returned: {(record.ReturnedDate.HasValue ? record.ReturnedDate.ToString() : "Not returned")}");
                }
                    Console.WriteLine();

                //library with most books
                var topLibrary = context.Libraries
                .Select(lib => new
                {
                    lib.Name,
                    BookCount = lib.Books.Count
                })
                .OrderByDescending(lib => lib.BookCount)
                .FirstOrDefault();

                Console.WriteLine($"Library with most books: {topLibrary.Name}, Total Books: {topLibrary.BookCount}");
                    Console.WriteLine();

                //readers wich not returned
                var readersWithUnreturnedBooks = context.Takens
                .Where(t => t.ReturnedDate == null)
                .Select(t => t.User.Name)
                .Distinct()
                .ToList();

                Console.WriteLine("Readers with unreturned books:");
                foreach (var reader in readersWithUnreturnedBooks)
                {
                    Console.WriteLine(reader);
                }
                    Console.WriteLine();

                //most popular genre
                var popularGenres = context.Takens
                .GroupBy(t => t.Book.Genre)
                .Select(g => new
                {
                    Genre = g.Key,
                    BorrowCount = g.Count()
                })
                .OrderByDescending(g => g.BorrowCount)
                .ToList();

                Console.WriteLine("Popular genres by borrow count:");
                foreach (var genre in popularGenres)
                {
                    Console.WriteLine($"{genre.Genre}: {genre.BorrowCount} borrows");
                }

            }

        }
    }
}
