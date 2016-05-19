using AdminDashboard.Common.Interfaces;
using AdminDashboard.DAL.EF;
using Autofac;

namespace AdminDashboard.Infrastructure
{
    public class EFModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType(typeof (SecurityAdminContext)).As<IDbContext>().InstancePerLifetimeScope();
            builder.RegisterType(typeof (UnitOfWork)).As<IUnitOfWork>().InstancePerLifetimeScope();

        }
    }
}
