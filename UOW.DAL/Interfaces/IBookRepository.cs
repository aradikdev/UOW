using UOW.DAL.Entities;

namespace UOW.DAL.Interfaces;

public interface IBookRepository : 
    IRepository<Book>, IDisposable
{
}
