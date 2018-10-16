using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace OzLearningHub
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "FreeBird",
                url: "Lessons/Lesson7_9/{name}/{age}/{color}",
                defaults: new
                {
                    controller = "Lessons",
                    action = "Lesson7_9",
                    name = UrlParameter.Optional,
                    age = UrlParameter.Optional,
                    color = UrlParameter.Optional
                },
                constraints: new { }
            );


            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
