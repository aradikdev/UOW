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
        var qwe = Guid.NewGuid().ToString();
        ViewBag.qwe = qwe;
        IEnumerable<Book> books = _uow.BookRepository.Get();
        return View(books);
    }

    public IActionResult Details(int id)
    {
        Book book = _uow.BookRepository.GetByID(id);
        return View(book);
    }
    public IActionResult Name(string bookName)
    {
        Book book = _uow.BookRepository.GetByName(bookName);
        return View(book);
    }

    public IActionResult Order(int id)
    {
        Order order = _uow.OrderRepository.GetByID(id);
        return View(order);
    }
}
