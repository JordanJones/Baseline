using System;
using System.Linq;
using System.Web.Http;
using System.Web.Http.OData.Builder;
using System.Web.Http.OData.Extensions;

using ODataEntityFramework.Models;

namespace ODataEntityFramework
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            var builder = new ODataConventionModelBuilder(config);
            builder.EntitySet<Users>("Users");

            config.Routes.MapODataServiceRoute(
                routeName : "ODataRoute",
                routePrefix : null,
                model : builder.GetEdmModel());

            // Web API routes
//            config.MapHttpAttributeRoutes();
//
//            config.Routes.MapHttpRoute(
//                name: "DefaultApi",
//                routeTemplate: "api/{controller}/{id}",
//                defaults: new { id = RouteParameter.Optional }
//            );
        }
    }
}
