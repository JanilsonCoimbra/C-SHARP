using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Atividade_19
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "RotaSalvar",
                url: "Cadastrar/salvar",
                defaults: new { controller = "Cadastrar", action = "Salvar" }
                );

            routes.MapRoute(
                name: "Veiculos",
                url: "Cadastrar",
                defaults: new { controller = "Cadastrar", action = "Veiculos" }
                );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
