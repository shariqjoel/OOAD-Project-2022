using IGogglesCare.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IGogglesCare.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ProductRepository productRepository = new ProductRepository();
            ViewBag.Products = productRepository.GetProduct();
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