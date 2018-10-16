using OzLearningHub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Web;
using System.Web.Mvc;

namespace OzLearningHub.Controllers
{
    public class LessonsController : Controller
    {
        // GET: Lessons
        public ActionResult Homework1()
        {
            return View();
        }

        public ActionResult Lesson1_2()
        {
            return View();
        }

        //FreeBird Assignment: Lesson 7-9
        public ActionResult Lesson7_9(string name = "Unknown", int age = -1, string color = "N/A")
        {
            var model = new FreeBirdModel()
            {
                Name = name,
                Age = age,
                Color = color,
            };

            return View(model);
        }

        public ActionResult Lesson9_10()
        {
            return View();
        }


        //Here is where the color mixer will happen
        public ActionResult Homework2(string colorMix1, string colorMix2)
        {
            if (colorMix1 == "1" && colorMix2 =="1")
            {
                ViewBag.mixedColor = "Red";
            }
            else if ((colorMix1 == "1" && colorMix2 == "3") || (colorMix1 == "3" && colorMix2 == "1"))
            {
                ViewBag.mixedColor = "Yellow";

            }
            else if ((colorMix1 == "1" && colorMix2 == "2") || (colorMix1 == "2" && colorMix2 == "1"))
            {
                ViewBag.mixedColor = "Magenta";
            }
            else if (colorMix1 == "3" && colorMix2 == "3")
            {
                ViewBag.mixedColor = "Green";
            }
            else if (colorMix1 == "2" && colorMix2 == "2")
            {
                ViewBag.mixedColor = "Blue";
            }
            else if ((colorMix1 == "3" && colorMix2 == "2") || (colorMix1 == "2" && colorMix2 == "3"))
            {
                ViewBag.mixedColor = "Cyan";
            }

            List<SelectListItem> colors = new List<SelectListItem>();
            SelectListItem color1 = new SelectListItem() {Text = "Red", Value = "1", Selected = false};
            SelectListItem color2 = new SelectListItem() { Text = "Blue", Value = "2", Selected = false};
            SelectListItem color3 = new SelectListItem() { Text = "Green", Value = "3", Selected = false };

            colors.Add(color1);
            colors.Add(color2);
            colors.Add(color3);
            //passing this value to Html Dropdown on backend side
            ViewBag.colorMix = colors;
            

            return View();
        }

        public ActionResult Lesson12()
        {
            // create an array of strings

            // "put" the array in the ViewBag
            ViewBag.balloons = balloons;

            return View();
        }
        //creating new method birthday

        string[] balloons = { "Red", "Blue", "Green", "Purple" };

        [HttpPost]
        public ActionResult Lesson12(FormCollection form)
        {

            @ViewBag.ResultName = form["name"];
            @ViewBag.ResultDB = form["birthday"];

            var balloon = form.AllKeys
                .Where(k => k.StartsWith("balloon"))
                .Select(k => form[k]);


            //foreach (var balloon in balloons)
            //{
            //    var b = form[balloon].Split(',');       //true, falsae
            //    var val = b[0];
            //    bool isChecked = Convert.ToBoolean(val);


            //    if (isChecked)      // if balloon checkbox is true
            //    {
            //        balloonList.Add(balloon); //add name of the balloon
            //    }
            //}

            ViewBag.BalloonList = balloon;  // storing values of checked balloons

            return View("Results");
        }


        public bool IsThisAKeyWeNeed(string x)
        {
            if (x.StartsWith("balloon"))

                return true;
            return false;
        }



    }
}