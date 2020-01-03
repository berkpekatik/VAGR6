using Autofac;
using Autofac.Integration.Mvc;
using R6Service.Interface;
using R6Service.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace R6VAG
{
    public class MvcApplication : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            var builder = new ContainerBuilder();
            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            builder.RegisterType<PlayerService>().As<IPlayerService>();
            var container = builder.Build();
            var config = GlobalConfiguration.Configuration;                        
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}