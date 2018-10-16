using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OzLearningHub.Controllers
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

        public ActionResult NewStuff(int? id)
        //public ActionResult NewStuff(int? id) - this can be used as well
        //public ActionResult NewStuff(int id=0) - this is having 0 as default in case if we do not pass any other value

        {

            ViewBag.qty = id;
            return View();
        }

        //public ActionResult AddNumber(string num1, string num2)
        //{
        //    ViewBag.a = num1;
        //    ViewBag.b = num2;

        //    return View();
        //}


        public ActionResult AddNumber(FormCollection form)
        {
            double num1, num2; 

            var num1Success = Double.TryParse(form["num1"], out num1);
            var num2Success = Double.TryParse(form["num2"], out num2);

            if (num1Success && num2Success)
            {
                ViewBag.Total = num1 + num2;

                ViewBag.a = num1;
                ViewBag.b = num2;
            }


            ViewBag.a = form["num1"];
            ViewBag.b = form["num2"];
            
            //ViewBag.Total = ViewBag.a + ViewBag.b + ViewBag.c;

            return View();
        }


        public ActionResult DisplayList()

        {

            ViewBag.Names = new string[] {"Jim", "Joe", "Janice", "Joan"};

            

            return View();
        }


    }
}