using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PRG522SA_6826.Controllers
{
    public class HomeController : Controller
    {
         
        // GET: Home
        public ActionResult Home()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Services()
        {
            return View();
        }

        [Authorize]
        public ActionResult Portfolio()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}