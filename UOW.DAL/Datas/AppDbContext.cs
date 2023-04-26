using Microsoft.EntityFrameworkCore;
using UOW.DAL.Entities;

namespace UOW.DAL.Datas;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }

    DbSet<Book> Books { get; set; }
    DbSet<Order> Orders { get; set; }
}
