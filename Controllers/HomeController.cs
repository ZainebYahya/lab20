using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lab20.Controllers
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
        
        public ActionResult Registration()
        {
            return View();
        }

        public ActionResult Welcome(string name,string cellphone,string Zipcode, string dateofbirth,string email)
        {
            ViewBag.Zipcode = Zipcode;
            ViewBag.cellphone = cellphone;
            ViewBag.name = name;
            ViewBag.dateofbirth = dateofbirth;
            ViewBag.email = email;
            return View();
        }


    }
}