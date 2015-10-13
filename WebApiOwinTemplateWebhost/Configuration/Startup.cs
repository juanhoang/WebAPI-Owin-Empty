using Microsoft.Owin;
using Owin;
using Rabbit.IOC;
using Rabbit.SimpleInjectorDemo.IocModules;
using SimpleInjector;
using SimpleInjector.Integration.WebApi;
using SimpleInjector.Packaging;
using System.Linq;
using WebApiOwinTemplateWebhost.Configuration;

[assembly: OwinStartup(typeof(Startup))]

namespace WebApiOwinTemplateWebhost.Configuration
{
    public class Startup
    {
        public void Configuration(IAppBuilder appBuilder)
        {
            var configuration = WebApiConfig.Register();

            var container = BuildContainer();
            configuration.DependencyResolver = new SimpleInjectorWebApiDependencyResolver(container);

            appBuilder.UseWebApi(configuration);
        }

        private Container BuildContainer()
        {
            var container = new Container();
            container.Options.DefaultScopedLifestyle = new WebApiRequestLifestyle();

            ModuleHelper.GetModuleTypes(typeof(WebApiConfig).Assembly, typeof(DemoServicesModule).Assembly)
                .CreateModules()
                .Cast<IPackage>()
                .ToList()
                .ForEach(x => x.RegisterServices(container));

            return container;
        }
    }
}