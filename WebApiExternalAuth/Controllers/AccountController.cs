using System.Web.Http;

namespace WebApiExternalAuth.Controllers
{
    public class AccountController : ApiController
    {
        [HttpGet]
        public IHttpActionResult Authenticate()
        {
            return new ChallengeResult("Google", "/api/Values", this.Request);
        }
    }
}