using HelloWorld.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloWorld.Controllers
{
    public class SecondController : Controller
    {
        // GET: Second
        public ActionResult Index()
        {
            ViewBag.x = 12;
            Person person = new Person() {id = 15, name = "Yurii" };
            return View(person);
        }
    }
}