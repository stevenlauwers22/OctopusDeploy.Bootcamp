﻿using System;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace OctopusDeploy.QFrameBootcamp.Web
{
    public class Global : HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            RegisterRoutes();
        }

        public static void RegisterRoutes()
        {
            var routes = RouteTable.Routes;
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.IgnoreRoute("{*favicon}", new { favicon = @"(.*/)?favicon.ico(/.*)?" });

            AreaRegistration.RegisterAllAreas();

            routes.MapRoute(
                "Default",
                "{controller}/{action}/{id}",
                new { controller = "Users", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}