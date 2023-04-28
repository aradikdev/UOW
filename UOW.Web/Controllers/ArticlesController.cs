using Microsoft.AspNetCore.Mvc;
using UOW.BLL.uow;
using UOW.DAL.Entities;

namespace UOW.Web.Controllers;

public class ArticlesController : Controller
{
    private readonly UnitOfWork _uow;

    public ArticlesController(UnitOfWork uow)
    {
        _uow = uow;
    }
    public IActionResult Index()
    {
        IEnumerable<Article> articles = _uow.ArticleRepository.Get();
        return View(articles);
    }
}
