using Microsoft.Owin;
using Owin;
using WebApiOwinTemplateWebhost.Configuration;

[assembly:OwinStartup(typeof(Startup))]

namespace WebApiOwinTemplateWebhost.Configuration
{
    public class Startup
    {
        public void Configuration(IAppBuilder appBuilder)
        {
            appBuilder.UseWebApi(WebApiConfig.Register());
        }
    }
}