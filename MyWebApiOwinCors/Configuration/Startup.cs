using Microsoft.Owin;
using Owin;
using MyWebApiOwinCors.Configuration;

[assembly: OwinStartup(typeof(Startup))]

namespace MyWebApiOwinCors.Configuration
{
    public class Startup
    {
        public void Configuration(IAppBuilder appBuilder)
        {
            appBuilder.UseWebApi(WebApiConfig.Register());
        }
    }
}