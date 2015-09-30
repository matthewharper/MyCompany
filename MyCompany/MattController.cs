using System.Collections.Generic;
using System.Web.Http;

namespace MyCompany
{
    public class MattController : ApiController
    {
        // GET: api/Matt
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Matt/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Matt
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Matt/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Matt/5
        public void Delete(int id)
        {
        }
    }
}
