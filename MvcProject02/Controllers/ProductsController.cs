using MvcProject02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProject02.Controllers
{
    public class ProductsController : Controller
    {
        List<Product> plist;
        public ProductsController()
        {
            plist = new List<Product>()
            {
                new Product {Id = 1,Name = "Laptop",Price = 300},
                new Product {Id = 2,Name = "Laptop 1",Price = 400},
                new Product {Id = 3,Name = "Laptop 2",Price = 500},
                new Product {Id = 4,Name = "Laptop 3",Price = 600},
            };
        }

        // GET: Products
        public ActionResult Index()
        {
            return View(plist);
        }

        public ContentResult SelectById(int id)
        {
            Product selectedProduct = plist.FirstOrDefault(z => z.Id == id);
            return Content(selectedProduct.Name + " " + selectedProduct.Price);
        }
    }
}