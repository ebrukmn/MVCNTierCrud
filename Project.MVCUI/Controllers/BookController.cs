using Project.BLL.RepositoryPattern.RepositoryConcrete;
using Project.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project.MVCUI.Controllers
{
    public class BookController : Controller
    {
        BookRepository brep = new BookRepository();
        AuthorRepository arep = new AuthorRepository();
        // GET: Book
        public ActionResult ListBooks()
        {
            return View(brep.SelectAll());
        }

        public ActionResult AddBook()
        {
            return View(Tuple.Create(arep.SelectAll(), new Book()));
        }

        [HttpPost]
        public ActionResult AddBook([Bind(Prefix = "Item2")] Book item)
        {
            brep.Add(item);
            return RedirectToAction("ListBooks");
        }

        public ActionResult DeleteBook(int id)
        {
            brep.Delete(brep.GetByID(id));
            return RedirectToAction("ListBooks");
        }

        public ActionResult UpdateBook(int id)
        {
            return View(Tuple.Create(arep.SelectAll(), brep.GetByID(id)));
        }

        [HttpPost]
        public ActionResult UpdateBook([Bind(Prefix = "Item2")] Book item)
        {
            brep.Update(item);
            return RedirectToAction("ListBooks");
        }
    }
}