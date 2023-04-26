using UOW.BLL.Repositories;
using UOW.DAL.Datas;
using UOW.DAL.Entities;

namespace UOW.BLL.uow;

public class UnitOfWork : IDisposable
{
    private AppDbContext context;
    public UnitOfWork(AppDbContext _context)
    {
        context = _context;
    }

    private Repository<Book> bookRepository;
    private Repository<Order> orderRepository;

    public Repository<Book> BookRepository
    {
        get
        {
            if (bookRepository == null)
            {
                bookRepository = new Repository<Book>(context);
            }
            return bookRepository;
        }
    }
    public Repository<Order> OrderRepository
    {
        get
        {
            if (orderRepository == null)
            {
                orderRepository = new Repository<Order>(context);
            }
            return orderRepository;
        }
    }

    public void Save()
    {
        context.SaveChanges();
    }

    private bool disposed = false;

    protected virtual void Dispose(bool disposing)
    {
        if (!this.disposed)
        {
            if (disposing)
            {
                context.Dispose();
            }
        }
        this.disposed = true;
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }
}
