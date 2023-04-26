using UOW.BLL.Repositories;
using UOW.DAL.Datas;
using UOW.DAL.Entities;
using UOW.DAL.Interfaces;

namespace UOW.BLL.uow;

public class UnitOfWork : IDisposable
{
    private AppDbContext context;
    public UnitOfWork(AppDbContext _context)
    {
        context = _context;
    }

    private BookRepository bookRepository;
    private OrderRepository orderRepository;

    public BookRepository BookRepository
    {
        get
        {
            if (bookRepository == null)
            {
                bookRepository = new BookRepository(context);
            }
            return bookRepository;
        }
    }
    public OrderRepository OrderRepository
    {
        get
        {
            if (orderRepository == null)
            {
                orderRepository = new OrderRepository(context);
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
