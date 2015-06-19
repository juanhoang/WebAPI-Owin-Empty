using System.Web.Http;

namespace WebApiOwinTemplateSelfhost.Registers
{
    public class WebApiRegister
    {
        public static HttpConfiguration BuildHttpConfiguration()
        {
            var config = new HttpConfiguration();
            config.Formatters.Remove(config.Formatters.XmlFormatter);

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/id",
                defaults: new { id = RouteParameter.Optional }
            );

            return config;
        }
    }
}