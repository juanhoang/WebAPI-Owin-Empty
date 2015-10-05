using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace MyWebApiOwinCors.Controllers
{
    public abstract class Base : ApiController
    {
        protected abstract IHttpActionResult Put(int id);
    }
}