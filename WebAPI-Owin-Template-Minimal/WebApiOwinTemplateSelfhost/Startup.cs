using Owin;
using WebApiOwinTemplateSelfhost.Registers;

namespace WebApiOwinTemplateSelfhost
{
    public class Startup
    {
        public void Configuration(IAppBuilder appBuilder)
        {
            appBuilder.UseWebApi(WebApiRegister.BuildHttpConfiguration());
        }
    }
}