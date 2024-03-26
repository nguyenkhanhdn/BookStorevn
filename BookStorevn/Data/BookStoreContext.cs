using BookStorevn.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStorevn.Data
{
    public class BookStoreContext:DbContext
    {
        public BookStoreContext(DbContextOptions<BookStoreContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Stationery> Stationeries { get; set; }
        
    }
}
