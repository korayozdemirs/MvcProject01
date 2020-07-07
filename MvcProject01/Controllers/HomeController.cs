using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProject01.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Test()
        {
            return View();
        }

        public ViewResult viewResult()
        {
            //Gerişye html içerik döndürür
            return View();
        }

        public ContentResult Contentresult()
        {
            //Geriye Content.
            return Content("Test");
        }

        public JsonResult Jsonresult()
        {
            //Geriye Json çıktısı dondurur.
            return Json("test");
        }

        public RedirectResult Redirectresult()
        {
            //Gerişye html içerik döndürür
            return Redirect("https://www.google.com");
        }

        public ActionResult RedirectAction()
        {
            //Index action yonelendırır.
            return RedirectToAction("Index");
        }





        private EmptyResult Emptyresult()
        {
            //Geriye boş sonuç dondurur.

            return new EmptyResult();
        }

        public FileContentResult Filecontentresult()
        {
            //Geriye FileContentResult.
            var file = new byte[3];
            return File(file, "test");
        }

        public FilePathResult Filepathresult()
        {
            //FileStreamResult.
            var file = new byte[3];
            return File("filepath", "contentTYpe");
        }





    }
}