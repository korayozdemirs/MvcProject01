using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProject04.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        NorthwindEntities db = new NorthwindEntities();
        public ActionResult CategoryList()
        {
            return View(db.Categories.ToList());
        }

        [HttpGet]
        public ActionResult CategoryAdd()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CategoryAdd(Category category)
        {
            db.Categories.Add(category);
            db.SaveChanges();
            return RedirectToAction("CategoryList");
        }

        public ActionResult CategoryUpdate(int id)
        {
            Category selectedCategory = db.Categories.FirstOrDefault(z => z.CategoryID == id);
            return View(selectedCategory);
        }

        [HttpPost]
        public ActionResult CategoryUpdate(Category category)
        {
            Category selectedCategory = db.Categories.FirstOrDefault(z => z.CategoryID == category.CategoryID);
            selectedCategory.CategoryName = category.CategoryName;
            selectedCategory.Description = category.Description;
            db.SaveChanges();
            return RedirectToAction("CategoryList");
        }

        public ActionResult CategoryDelete(int id)
        {
            Category selectedCategory = db.Categories.FirstOrDefault(z => z.CategoryID == id);
            db.Categories.Remove(selectedCategory);
            db.SaveChanges();
            return RedirectToAction("CategoryList");
        }
    }
}