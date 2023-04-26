using UOW.DAL.Interfaces;

namespace UOW.BLL.Repositories;

public class Repository<T> : IRepository<T> where T : class
{
    public void Delete(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<T> Get()
    {
        throw new NotImplementedException();
    }

    public T GetByID(int id)
    {
        throw new NotImplementedException();
    }

    public void Insert(T entity)
    {
        throw new NotImplementedException();
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
