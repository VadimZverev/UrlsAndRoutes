using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace UrlsAndRoutes
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            //  Смешивание статических URL сегментов и значений по умолчанию
            routes.MapRoute("ShopSchema", "Shop/{action}",
                new { controller = "Home" });

            // URL паттерн со смешанным сегментом
            routes.MapRoute("", "X{controller}/{action}");

            // роут значений по умолчанию для действия и контроллера
            routes.MapRoute("MyRoute", "{controller}/{action}",
                new { controller = "Home", action = "Index" });

            // URL паттерн со статическими сегментами
            routes.MapRoute("", "Public/{controller}/{action}",
                new { controller = "Home", action = "Index" });
        }
    }
}
