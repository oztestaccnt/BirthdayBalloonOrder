using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OzLearningHub.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult SignIn()
        {
            return View();

        }
        public ActionResult Register()
        {
            return View();
        }

        public ActionResult Account()
        {
            return View();
        }
    }
}