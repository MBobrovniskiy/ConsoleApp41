using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsoleApp41.Migrations
{
    /// <inheritdoc />
    public partial class m1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Libraries",
                columns: new[] { "Id", "Name", "Address" },
                values: new object[,]
                {
                    { 1, "Central Library", "123 Library St" },
                    { 2, "East Side Library", "456 East St" },
                    { 3, "West Side Library", "789 West St" },
                    { 4, "North Side Library", "101 North St" },
                    { 5, "South Side Library", "202 South St" },
                    { 6, "Downtown Library", "303 Main St" }
                });

            migrationBuilder.InsertData(
                table: "Readers",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "John Doe" },
                    { 2, "Jane Smith" },
                    { 3, "Alice Johnson" },
                    { 4, "Bob Brown" },
                    { 5, "Chris Green" },
                    { 6, "Dana White" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Title", "Author", "Genre", "LibraryId", "ReaderId" },
                values: new object[,]
                {
                    { 1, "Book One", "Author A", "Fiction", 1, null },
                    { 2, "Book Two", "Author B", "Non-Fiction", 1, 1 },
                    { 3, "Book Three", "Author C", "Science", 2, null },
                    { 4, "Book Four", "Author D", "Fantasy", 2, 2 },
                    { 5, "Book Five", "Author E", "Horror", 3, null },
                    { 6, "Book Six", "Author F", "Biography", 3, 3 },
                    { 7, "Book Seven", "Author G", "Adventure", 4, 4 },
                    { 8, "Book Eight", "Author H", "Mystery", 4, null },
                    { 9, "Book Nine", "Author I", "Drama", 5, 5 },
                    { 10, "Book Ten", "Author J", "Thriller", 5, null },
                    { 11, "Book Eleven", "Author K", "Poetry", 6, 6 },
                    { 12, "Book Twelve", "Author L", "Comedy", 6, null }
                });

            migrationBuilder.InsertData(
                table: "Takens",
                columns: new[] { "Id", "UserId", "BookId", "BorrowedDate", "ReturnedDate" },
                values: new object[,]
                {
                    { 1, 1, 2, DateTime.UtcNow.AddDays(-10), null },
                    { 2, 2, 4, DateTime.UtcNow.AddDays(-20), DateTime.UtcNow.AddDays(-5) },
                    { 3, 3, 6, DateTime.UtcNow.AddDays(-15), null },
                    { 4, 4, 7, DateTime.UtcNow.AddDays(-30), DateTime.UtcNow.AddDays(-10) },
                    { 5, 5, 9, DateTime.UtcNow.AddDays(-25), null },
                    { 6, 6, 11, DateTime.UtcNow.AddDays(-5), null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
