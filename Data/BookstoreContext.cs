using Microsoft.EntityFrameworkCore;
using BookstoreManagement.Models;

public class BookstoreContext : DbContext
{
    public BookstoreContext(DbContextOptions<BookstoreContext> options) : base(options) { }

    public DbSet<Book> Books { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Book>().HasData(
            new Book { Id = 1, Title = "The Great c#", Author = "Saja", Price = 10.99, Genre = "Learning" },
            new Book { Id = 2, Title = "I miss You Dad", Author = "Fawaz", Price = 8.99, Genre = "Exactly Loved"  },
            new Book { Id = 3, Title = "Hello World", Author = "Mahmood", Price = 7.99, Genre = "Road of Life" }
        );
    }
}

