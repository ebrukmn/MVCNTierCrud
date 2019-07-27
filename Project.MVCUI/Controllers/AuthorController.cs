using Project.BLL.RepositoryPattern.RepositoryConcrete;
using Project.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project.MVCUI.Controllers
{
    public class AuthorController : Controller
    {
        AuthorRepository arep = new AuthorRepository();
        // GET: Author
        public ActionResult ListAuthors()
        {
            return View(arep.SelectAll());
        }

        public ActionResult AddAuthor()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddAuthor(Author item)
        {
            if (arep.Any(x=>x.Name==item.Name && x.LastName==item.LastName))
            {
                return RedirectToAction("ListAuthors");
            }
            else
            {
                arep.Add(item);
                return RedirectToAction("ListAuthors");
            }
        }

        public ActionResult DeleteAuthor(int id)
        {
            arep.Delete(arep.GetByID(id));
            return RedirectToAction("ListAuthors");
        }
        
        public ActionResult UpdateAuthor(int id)
        {
            return View(arep.GetByID(id));
        }

        [HttpPost]
        public ActionResult UpdateAuthor(Author item)
        {
            arep.Update(item);
            return RedirectToAction("ListAuthors");
        }
    }
}