using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string searchString)
        {
            var lst = new List<Product>();
            for (int i = 0; i < 5; i++)
            {
                lst.Add(new Product
                {
                    Id = i + 1,
                    Name = "Product" + i,
                    Description = "Description" + i,
                    Price = i * 10,
                });
            }

            if (!string.IsNullOrEmpty(searchString))
            {
                lst = lst.Where(p => p.Name.Contains(searchString)).ToList();
            }

            return View(lst);
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