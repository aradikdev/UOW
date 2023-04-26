using Microsoft.EntityFrameworkCore;
using UOW.DAL.Datas;
using UOW.DAL.Interfaces;

namespace UOW.BLL.Repositories;

public class Repository<T> : IRepository<T> where T : class
{
    private readonly AppDbContext _db;
    private readonly DbSet<T> dbSet;

    public Repository(AppDbContext db)
    {
        _db = db;
        dbSet = _db.Set<T>();
    }
    public T GetByID(int id)
    {
        return dbSet.Find(id);
    }
    public IEnumerable<T> Get()
    {
        return dbSet.ToList(); ;
    }
    public void Insert(T entity)
    {
        dbSet.Add(entity);
    }

    public void Delete(int id)
    {
        T entityToDelete = dbSet.Find(id);
        Delete(entityToDelete);
    }
    public void Delete(T entity)
    {
        if (_db.Entry(entity).State == EntityState.Detached)
        {
            dbSet.Attach(entity);
        }
        dbSet.Remove(entity);
    }

    public void Save()
    {
        throw new NotImplementedException();
    }

    public void Update(T entity)
    {
        throw new NotImplementedException();
    }
}
