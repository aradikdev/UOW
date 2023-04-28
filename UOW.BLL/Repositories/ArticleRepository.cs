using UOW.DAL.Datas;
using UOW.DAL.Entities;

namespace UOW.BLL.Repositories;

public class ArticleRepository : Repository<Article>
{
    public ArticleRepository(AppDbContext db) : base(db)
    {
    }
}
