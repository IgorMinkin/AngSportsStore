using System.Reflection;
using System.Web.Http;
using Autofac;
using Autofac.Integration.WebApi;
using SportsStore.Data;
using SportsStore.Properties;

namespace SportsStore
{
    public class AutofacConfig
    {
        public static void RegisterBindings(HttpConfiguration configuration)
        {
            var builder = new ContainerBuilder();
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());
            AddBindings(builder);
            var container = builder.Build();
            var resolver = new AutofacWebApiDependencyResolver(container);
            configuration.DependencyResolver = resolver;
        }

        private static void AddBindings(ContainerBuilder builder)
        {
            string connectionString = Settings.Default.ConnectionString;
            builder.RegisterType<SportsStoreDbContext>()
                .WithParameter("connectionString", connectionString)
                .InstancePerApiRequest();
        }
    }
}