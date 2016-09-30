using DavidCore.Concrete;
using DavidCore.Models;
using DavidPortal.App_Start;
using DavidPortal.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace DavidPortal
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            using (DavidCloud davidCloud = new DavidCloud())
            {
                davidCloud.Database.CreateIfNotExists();
            }

            AreaRegistration.RegisterAllAreas();
            UnityWebActivator.Start();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
