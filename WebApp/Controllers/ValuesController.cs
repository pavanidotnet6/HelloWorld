using Shared.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    //[Authorize]
    public class ValuesController : ApiController
    {
        private IHelloWorldService _hellowrorldService;

        [System.Web.Http.HttpGet]
        public HttpResponseMessage Index()
        {
            HttpResponseMessage temp = new HttpResponseMessage();
            return temp;
        }


        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
        /// <summary>
        /// API call 
        /// </summary>
        /// <param name="ci"></param>
        /// <returns></returns>
        [System.Web.Http.Route("api/HelloWorld")]
        public HttpResponseMessage HelloWorld(string ci)
        {

            var outputText = _hellowrorldService.GetTextFromUnitOfWork(ci);

            var resp = new HttpResponseMessage(HttpStatusCode.OK);

            resp.Content = new StringContent(ci, System.Text.Encoding.UTF8, "text/plain");

            return resp;
        }
    }
}
