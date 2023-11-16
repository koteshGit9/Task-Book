using BookTask.Entity;
using Microsoft.EntityFrameworkCore;

namespace BookTask.Database
{
    public class BookContext:DbContext
    { public DbSet<Book>  Books { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data source = MSI\\SQLEXPRESS; Initial Catalog=BooksTask;User Id=kotesh;Password=Kolli@123;TrustServerCertificate=true");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
