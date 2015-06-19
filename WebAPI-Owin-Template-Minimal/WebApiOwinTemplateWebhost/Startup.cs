using Owin;
using WebAPI_Owin_Template_Minimal.Registers;

namespace WebAPI_Owin_Template_Minimal
{
    public class Startup
    {
        public void Configuration(IAppBuilder appBuilder)
        {
            appBuilder.UseWebApi(WebApiRegister.BuildHttpConfiguration());
        }
    }
}