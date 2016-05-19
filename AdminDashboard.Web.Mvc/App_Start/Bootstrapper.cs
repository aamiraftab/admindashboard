using System.Web.Mvc;
using AdminDashboard.Infrastructure;
using Autofac;
using Autofac.Integration.Mvc;

namespace AdminDashboard.Web.Mvc
{
    public class Bootstrapper
    {
        public static void Run()
        {
            SetAutofacContainer();
        }

        private static void SetAutofacContainer()
        {
            var builder = new Autofac.ContainerBuilder();

            builder.RegisterControllers(typeof(MvcApplication).Assembly).PropertiesAutowired();

            //Cross cutting layer
            builder.RegisterModule(new EFModule());
            builder.RegisterModule(new RepositoryModule());
            builder.RegisterModule(new ServiceModule());


            var container = builder.Build();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}