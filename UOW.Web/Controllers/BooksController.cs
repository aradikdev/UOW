using Microsoft.AspNetCore.Mvc;
using UOW.BLL.uow;
using UOW.DAL.Entities;

namespace UOW.Web.Controllers;

public class BooksController : Controller
{
    private readonly UnitOfWork _uow;

    public BooksController(UnitOfWork uow)
    {
        _uow = uow;
    }

    public IActionResult Index()
    {
        IEnumerable<Book> books = _uow.BookRepository.Get();
        return View(books);
    }

    public IActionResult Details(int id)
    {
        Book book = _uow.BookRepository.GetByID(id);
        return View(book);
    }
}
