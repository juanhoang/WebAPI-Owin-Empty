using Microsoft.Owin;
using Owin;
using WebApiOwinTemplateWebhost;
using WebApiOwinTemplateWebhost.Configuration;

[assembly: OwinStartup(typeof(Startup))]

namespace WebApiOwinTemplateWebhost
{
    public class Startup
    {
        public void Configuration(IAppBuilder appBuilder)
        {
            var configuration = WebApiConfig.Register();

            //  Register an IOC
            configuration.RegisterDependencyResolver();

            appBuilder.UseWebApi(configuration);
        }
    }
}