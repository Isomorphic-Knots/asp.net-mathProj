using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace aspPractice
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            /*custom route
                new argument to routemap method, applying constraints
                Somewhat pointless, used as an exersize to learn.
                \d for digits
                for very specific choices - example if it is an int 
                parameter then use @"2017 | 2018" to limit the choices
                to just 2017 and 2018
                @"\w{30} limits to character choice of size 30
                however, this is fragile because there is a chance it may
                not be used (although this would be great if it were guaranteed
                to be used often, as it is efficient.
                efficient since it does not take up much space.)
                could be example of "magic strings" aka unexpected results
                also, could be good to know when working with older codebase!
            routes.MapRoute(
                "MathByDifficulty",
                "Math/Subjects/{level}/{type}",
                new { controller = "Math", action = "ByDifficulty" });*/

            /*attribute routing, more new and fancy way of passing custom URLS in asp.net
            assigns an attibute to corresponding action
            good for customized url templates, much more versatile*/
            routes.MapMvcAttributeRoutes();



           //default route
           routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
