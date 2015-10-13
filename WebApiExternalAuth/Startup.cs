using Microsoft.Owin;
using Owin;
using WebApiExternalAuth;
using WebApiExternalAuth.Configuration;

[assembly: OwinStartup(typeof(Startup))]

namespace WebApiExternalAuth
{
    public class Startup
    {
        public void Configuration(IAppBuilder appBuilder)
        {
            var configuration = WebApiConfig.Register();

            IocConfig.RegisterDependencyResolver(configuration);

            SecurityConfig.Configure(appBuilder);

            appBuilder.UseWebApi(configuration);
        }
    }
}