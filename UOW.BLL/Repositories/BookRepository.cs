using UOW.DAL.Datas;
using UOW.DAL.Entities;
using UOW.DAL.Interfaces;

namespace UOW.BLL.Repositories;

public class BookRepository : Repository<Book>
{
    public BookRepository(AppDbContext db) : base(db)
    {
    }
}
