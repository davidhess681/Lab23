using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab23.Models;

namespace Lab23.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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
         
        public ActionResult UserRegistration()
        {
            return View();
        }
        public ActionResult AddUser(User newUser)
        {
            CoffeeShopDBLab23Entities1 DB = new CoffeeShopDBLab23Entities1();
            DB.Users.Add(newUser);
            DB.SaveChanges();
            ViewBag.AddedItem = "Item was successfully added";
            return View("UserRegistration");
        }
    }
}