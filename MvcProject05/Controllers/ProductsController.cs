using MvcProject05.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace MvcProject05.Controllers
{
    public class ProductsController : Controller
    {
        List<Product> plist;
        public ProductsController()
        {
            plist = new List<Product>()
            {
                new Product{Id = 1,Name = "Laptop",Price  = 100,Ready = true,UnistInStock = 10},
                new Product{Id = 2,Name = "Laptop 2",Price  = 200,Ready = true,UnistInStock = 20},
                new Product{Id = 3,Name = "Laptop 3",Price  = 300,Ready = true,UnistInStock = 30},
                new Product{Id = 4,Name = "Laptop 4",Price  = 400,Ready = true,UnistInStock = 40},
            };
        }
        // GET: Products
        public JsonResult Get()
        {
            return Json(plist, JsonRequestBehavior.AllowGet);
        }

        public ActionResult ProductAdd()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ProductAdd(Product product)
        {
            //Model şartları sağlıyorsa
            if (ModelState.IsValid)
            {
                //ekleme kodlarıu
            }
            return View(product);
        }

    }
}