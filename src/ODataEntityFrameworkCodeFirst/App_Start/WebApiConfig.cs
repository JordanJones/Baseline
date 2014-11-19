﻿using System;
using System.Linq;
using System.Web.Http;
using System.Web.Http.OData.Builder;
using System.Web.Http.OData.Extensions;

using ODataEntityFrameworkCodeFirst.Models;

namespace ODataEntityFrameworkCodeFirst
{
    public static class WebApiConfig
    {

        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            var builder = new ODataConventionModelBuilder(config);
            builder.EntitySet<Users>("Users");

            config.Routes.MapODataServiceRoute("ODataRoute", null, builder.GetEdmModel());

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
