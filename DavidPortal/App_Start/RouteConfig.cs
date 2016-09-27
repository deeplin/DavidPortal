using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace DavidPortal
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //routes.MapRoute(
            //    name: "Default",
            //    url: "{controller}/{action}/{id}",
            //    defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            //);

            routes.MapRoute(null,
                "",
                new
                {
                    controller = "Admin",
                    action = "Index",
                    category = (string)null,
                    page = 1
                }
            );

            routes.MapRoute(null,
                "Page{page}",
                new { controller = "Device", action = "List", category = (string)null },
                new { page = @"\d+" }
            );

            routes.MapRoute(null,
                "{model}",
                new { controller = "Device", action = "List", page = 1 }
            );

            routes.MapRoute(null,
                "{model}/Page{page}",
                new { controller = "Device", action = "List" },
                new { page = @"\d+" }
            );

            routes.MapRoute(null, "{controller}/{action}");
        }
    }
}
