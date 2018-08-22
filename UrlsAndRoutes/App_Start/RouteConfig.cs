﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using UrlsAndRoutes.Infrastructure;

namespace UrlsAndRoutes
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.RouteExistingFiles = true;
            routes.MapRoute("DiskFile", "Content/StaticContent.html",
                new
                {
                    controller = "Customer",
                    action = "List"
                });

            routes.MapRoute("ChromeRoute", "{*catchall}",
                new { controller = "Home", action = "Index" },
                new
                {
                    customConstraint = new UserAgentConstraint("Chrome")
                },
                new[] { "UrlsAndRoutes.AdditionalControllers" });

            routes.MapRoute("MyRoute", "{controller}/{action}/{id}/{*catchall}",
                new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                new
                {
                    controller = "^H.*",
                    action = "Index|About",
                    httpMethod = new HttpMethodConstraint("GET")
                },
                new[] { "UrlsAndRoutes.Controllers" });
        }
    }
}
