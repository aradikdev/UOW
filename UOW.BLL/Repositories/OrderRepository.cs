using UOW.DAL.Datas;
using UOW.DAL.Entities;

namespace UOW.BLL.Repositories;

public class OrderRepository : Repository<Order>
{
    private readonly AppDbContext _db;

    public OrderRepository(AppDbContext db) : base(db)
    {
        _db = db;
    }
}
