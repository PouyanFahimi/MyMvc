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

        public string GetName(string Name)
        {
            return Name;
        }
    }
}