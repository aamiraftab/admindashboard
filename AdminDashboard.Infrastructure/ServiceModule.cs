using System.Reflection;
using Autofac;

namespace AdminDashboard.Infrastructure
{
    public class ServiceModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(Assembly.Load("SecurityAdmin.Service"))
             .Where(t => t.Name.EndsWith("Service"))
             .AsImplementedInterfaces()
             .InstancePerLifetimeScope();
        }
    }
}
