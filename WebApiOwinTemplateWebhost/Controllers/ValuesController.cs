using Rabbit.SimpleInjectorDemo.Services;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace WebApiOwinTemplateWebhost.Controllers
{
    public class ValuesController : ApiController
    {
        private readonly IListingService _listingService;

        public ValuesController(IListingService listingService)
        {
            _listingService = listingService;
        }

        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value" + id;
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
            Console.WriteLine(value);
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
            Console.WriteLine(id + value);
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            Console.WriteLine(id);
        }
    }
}