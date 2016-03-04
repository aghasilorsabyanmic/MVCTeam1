using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RESTfull.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        [HttpGet]
        public IHttpActionResult Get1(int count)
        {
            //NotFound();
            //Created(location, content)
            //return BadRequest(ModelState);
            //return BadRequest();
            //return BadRequest("custom mesage");
            //return NotFound();
            //throw new Exception();
            return Ok(new string[] { "value1", "value2" });
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
    }
}
