using Microsoft.EntityFrameworkCore;
using UOW.DAL.Entities;

namespace UOW.DAL.Datas;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Book> Books { get; set; }
    public DbSet<Order> Orders { get; set; }
}
