using UOW.DAL.Datas;
using UOW.DAL.Entities;

namespace UOW.BLL.Repositories;

public class BookRepository : Repository<Book>
{
    private readonly AppDbContext _db;

    public BookRepository(AppDbContext db) : base(db)
    {
        _db = db;
    }

    public Book GetByName(string bookName)
    {
        Book book = _db.Books.FirstOrDefault(x => x.Name == bookName);
        return book;
    }
}
