using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Formatting;
using System.Web.Http;

namespace WebAPI_Course_App
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            config.Formatters.Remove(config.Formatters.JsonFormatter); // allows to see xml output in the browser vs JSON
            // config.Formatters.Add(new BsonMediaTypeFormatter());

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                //routeTemplate: "api/{controller}/{action}/{id}", // enable for demonstration with custom method names
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
