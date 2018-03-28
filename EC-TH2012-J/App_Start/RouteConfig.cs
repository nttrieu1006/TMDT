using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace EC_TH2012_J
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Product Detail",
                url: "chi-tiet/{metatitle}-{id}",
                defaults: new { controller = "SanPham", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "EC-TH2012-J.Controllers" }
            );
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
                name: "Cart",
                url: "gio-hang/",
                defaults: new { controller = "Home", action = "Cart", id = UrlParameter.Optional },
                namespaces: new[] { "EC-TH2012-J.Controllers" }
            );
            routes.MapRoute(
                name: "Checkout",
                url: "mua-hang/",
                defaults: new { controller = "Home", action = "Checkout", id = UrlParameter.Optional },
                namespaces: new[] { "EC-TH2012-J.Controllers" }
            );
            routes.MapRoute(
                name: "Search",
                url: "tim-kiem",
                defaults: new { controller = "Search", action = "AdvancedSearchView", id = UrlParameter.Optional },
                namespaces: new[] { "EC-TH2012-J.Controllers" }
            );

            routes.MapRoute(
                name: "Login",
                url: "dang-nhap/",
                defaults: new { controller = "Account", action = "Authentication", id = UrlParameter.Optional },
                namespaces: new[] { "EC-TH2012-J.Controllers" }
            );
            routes.MapRoute(
                name: "Register",
                url: "dang-ki-ncc/",
                defaults: new { controller = "Account", action = "RegisterB2B", id = UrlParameter.Optional },
                namespaces: new[] { "EC-TH2012-J.Controllers" }
            );
            routes.MapRoute(
               name: "Register Buy",
               url: "dang-ki-sp-can-ban/",
               defaults: new { controller = "Auction", action = "Index", id = UrlParameter.Optional },
               namespaces: new[] { "EC-TH2012-J.Controllers" }
           );
            routes.MapRoute(
                name: "Manager Account",
                url: "cap-nhat-mat-khau/",
                defaults: new { controller = "Account", action = "Manage", id = UrlParameter.Optional },
                namespaces: new[] { "EC-TH2012-J.Controllers" }
            );
            routes.MapRoute(
                name: "Manager Info",
                url: "cap-nhat-thong-tin/",
                defaults: new { controller = "Account", action = "EditNCCInfo", id = UrlParameter.Optional },
                namespaces: new[] { "EC-TH2012-J.Controllers" }
            );

            routes.MapRoute(
                name: "Home",
                url: "",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "EC-TH2012-J.Controllers" }
            );
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "EC-TH2012-J.Controllers" }
            );

        }
    }
}
