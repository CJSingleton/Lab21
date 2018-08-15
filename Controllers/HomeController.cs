using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab21.Models;

namespace Lab21.Controllers
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
            ViewBag.Message = "Registration for Chris's Coffee";

            return View();
        }

        public ActionResult Signup()
            {
                return View();
            }

        public ActionResult AddUser(UserInfo newUser)
        {
            //to do: validation! - NEVER SKIP
            if (ModelState.IsValid)
            {
                //to do: send data to database

                //to do: confirmation, or go back to index
                //old way - ViewData["ConfMessage"] = "Thanks" + newUser.FirstName;

                ViewBag.ConfMessage = "Welcome, " + newUser.FirstName;

                return View("Confirm");
            }
            else
            {
                return View("Error");
            }
        }
    }
}