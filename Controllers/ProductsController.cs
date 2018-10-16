using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OzLearningHub.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Category()
        {
            return View();
        }

        public ActionResult Discount()
        {
            return View();
        }
    }
}