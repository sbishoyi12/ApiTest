using Microsoft.EntityFrameworkCore;
using my_books.Data.Models;

namespace my_books_webapi.Data
{
    public class AppDbContext:DbContext
    {
        
        public AppDbContext(DbContextOptions<DbContext> options): base(options)
        {

        }
        public DbSet<Book> Books { get; set; }
    }
}
