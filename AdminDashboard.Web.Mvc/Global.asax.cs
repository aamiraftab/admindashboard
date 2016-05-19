using System.Web.Mvc;
using System.Web.Routing;
using AdminDashboard.Infrastructure;
using Autofac;
using Autofac.Integration.Mvc;

namespace AdminDashboard.Web.Mvc
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            
            //Autofac and Automapper Configurations
            Bootstrapper.Run();
        }
    }
}
