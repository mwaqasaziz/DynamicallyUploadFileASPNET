using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestApplicationFileInput.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Employee(FormCollection data)
        {
            List<string> attachs = data.AllKeys.Where(k => k.Contains("Attach")).ToList();

            foreach (var attach in attachs)
            {
                string x = data[attach];
            }

            return View();
        }
    }
}