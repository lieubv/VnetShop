
using System.Reflection;
using VnetShop.Data.Infrastructure;
using VnetShop.Data;
using VnetShop.Data.Repositories;
using VnetShop.Service;
using Microsoft.Owin;
using Owin;
using Autofac;
using System.Web.Mvc;
using Autofac.Integration.Mvc;
using System.Web.Http;
using Autofac.Integration.WebApi;

[assembly: OwinStartup(typeof(VnetShop.Web.App_Start.Startup))]

namespace VnetShop.Web.App_Start
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=316888
            ConfigAutofac(app);
        }
        // Create a config function
        private void ConfigAutofac(IAppBuilder app)
        {
            var builder = new ContainerBuilder();

            // Register for Web Controller
            builder.RegisterControllers(Assembly.GetExecutingAssembly());

            // Register for WebApi
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerRequest();
            builder.RegisterType<DbFactory>().As<IDbFactory>().InstancePerRequest();

            builder.RegisterType<VnetShopDbContext>().AsSelf().InstancePerRequest();

            //Register for all Repositories
            builder.RegisterAssemblyTypes(typeof(UserRepository).Assembly)
                .Where(t => t.Name.EndsWith("Repository"))
                .AsImplementedInterfaces().InstancePerRequest();

            //Register for all Services
            builder.RegisterAssemblyTypes(typeof(UserService).Assembly)
                .Where(t => t.Name.EndsWith("Service"))
                .AsImplementedInterfaces().InstancePerRequest();

            Autofac.IContainer container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

            GlobalConfiguration.Configuration.DependencyResolver = new AutofacWebApiDependencyResolver((IContainer)container);
        }
    }
}
