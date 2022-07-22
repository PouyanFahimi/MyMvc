using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyMvc.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public string Name()
        {
            return "Hi";
        }

        public ActionResult Home()
        {
            return View();
        }

        public string GetName(string Name)
        {
            return Name;
        }

        public string ShowDate()
        {
            return DateTime.Now.ToString();
        }

        public ViewResult ContactUs()
        {
            return View("CountactUs");
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult SendViewBag()
        {
            ViewBag.Name = DateTime.Now;

            var NameList = new List<string>
            {
                "01","02","03","04","05","06","07","08"
            };
            ViewBag.listName = NameList;
            return View();
        }

        public ActionResult id(int id = 0)
        {
            ViewBag.id = id;

            return View();
        }

        public ActionResult GetPersonalInfo(string name, string family, int? age)
        {
            if (age == null)
                ViewBag.ErrorMessage = "Please fill in all entries";
            return View("_ErrorMessage");

            if (age <= 13)
                ViewBag.Message = " You cant view the page";
            return View("_Message");

            ViewBag.Name = name;
            ViewBag.family = family;
            ViewBag.age = age;

            return View();
        }

    }
}