using Rabbit.IOC;
using Rabbit.SimpleInjectorDemo.IocModules;
using SimpleInjector;
using SimpleInjector.Integration.WebApi;
using SimpleInjector.Packaging;
using System.Linq;
using System.Web.Http;

namespace WebApiOwinTemplateWebhost.Configuration
{
    public static class IocConfig
    {
        public static void RegisterDependencyResolver(this HttpConfiguration configuration)
        {
            var container = BuildContainer();
            configuration.DependencyResolver = new SimpleInjectorWebApiDependencyResolver(container);
        }

        private static Container BuildContainer()
        {
            var container = new Container();
            container.Options.DefaultScopedLifestyle = new WebApiRequestLifestyle();

            // TODO: Update all assemblies which contain IoC modules here
            var possibleAssemblies = new[]
            {
                typeof (WebApiConfig).Assembly,
                typeof (DemoServicesModule).Assembly
            };

            ModuleHelper.GetModuleTypes(possibleAssemblies)
                .CreateModules()
                .Cast<IPackage>()
                .ToList()
                .ForEach(x => x.RegisterServices(container));

            return container;
        }
    }
}