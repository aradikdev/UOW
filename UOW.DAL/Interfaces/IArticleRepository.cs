using UOW.DAL.Entities;

namespace UOW.DAL.Interfaces;

internal interface IArticleRepository 
    : IRepository<Article>, IDisposable
{

}
