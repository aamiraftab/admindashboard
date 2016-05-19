using System.Reflection;
using AdminDashboard.Common.Interfaces;
using AdminDashboard.DAL.EF;
using Autofac;

namespace AdminDashboard.Infrastructure
{
    public class RepositoryModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterGeneric(typeof(GenericRepository<>)).As(typeof(IRepository<>)).InstancePerLifetimeScope();
            builder.RegisterAssemblyTypes(Assembly.Load("SecurityAdmin.Dal.EF"))
                  .Where(t => t.Name.EndsWith("Repository"))
                  .AsImplementedInterfaces()
                 .InstancePerLifetimeScope();
        }
    }
}
