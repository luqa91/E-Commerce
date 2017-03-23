using E_Commerce.DAL;
using E_Commerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace E_Commerce.Controllers
{
    public class HomeController : Controller
    {
        private ProductsContext db = new ProductsContext();
        public ActionResult Index()
        {
            Category category = new Category {NameCategory="Electronics", NameFileIcon="electronics.png", DescriptionCategory="opis" };
            db.Categories.Add(category);
            db.SaveChanges();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}