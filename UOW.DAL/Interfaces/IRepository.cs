using UOW.DAL.Entities;

namespace UOW.DAL.Interfaces;

public interface IRepository<T> where T : class
{
    IEnumerable<T> Get();
    T GetByID(int id);
    void Insert(T entity);
    void Delete(int id);
    void Delete(T entity);
    void Update(T entity);
    void Save();
}
