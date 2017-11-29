using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Teknologisk;

namespace DataAnnotation.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet]
        public ActionResult Index()
        {
            PersonRepository r = new PersonRepository();
            return View(r.GetPerson());
        }

        [HttpPost]
        public ActionResult Index(Person person)
        {
            return View(person);

        }

    }
}
