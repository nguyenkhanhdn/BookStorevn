using BookStorevn.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStorevn.Data
{
    public class BookStoreContext:DbContext
    {
        public BookStoreContext(DbContextOptions<BookStoreContext> options)
            : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Stationery> Stationeries { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<OrderMaster> OrderMasters { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
    }
}
