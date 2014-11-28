using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lirio2.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            var hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour > 12 ? "Buenos Dias!!" : hour > 19 ? "Buenas Noches!!" : "Buenas Tardes!!";

            return View();

        }
    }
}
