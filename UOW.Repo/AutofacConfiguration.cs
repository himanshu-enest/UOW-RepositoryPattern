using Autofac;
using System.Reflection;
using UOW.Repo.Repository.DbRepository;
using UOW.Repo.Repository.Infrastructure;
using UOW.Repo.Repository.UnitOfWork;

namespace UOW.Repo
{
    public class AutofacConfiguration
    {
        public static IContainer Configure()
        {
            // Create your builder.
            var builder = new ContainerBuilder();

            // Registers business service assembly all at once
            builder.RegisterAssemblyTypes(Assembly.Load("UOW.Repo.Business")).Where(x => x.Name.EndsWith("AppService"))
                .AsImplementedInterfaces().OwnedByLifetimeScope();

            // Registers generic types
            builder.RegisterGeneric(typeof(UnitOfWork<>)).As(typeof(IUnitOfWork<>)).OwnedByLifetimeScope();
            builder.RegisterGeneric(typeof(Repository<>)).As(typeof(IRepository<>)).OwnedByLifetimeScope();

            // Registers single type
            builder.RegisterType<DbRepository>().As<IDbRepository>().OwnedByLifetimeScope();

            var container = builder.Build();
            
            return container;
        }
    }
}
