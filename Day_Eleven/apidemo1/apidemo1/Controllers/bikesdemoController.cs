using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace apidemo1.Controllers
{
    public class bikesdemoController : ApiController
    {

        List<string> bikes = InitBikes();
        public static List<string> InitBikes()
        {

            var bikes = new List<string>() { "Yamaha", "Honda", "Duke", "Pulsar", "RoyalEnfield" };
            return bikes;
        }
        // GET: api/bikesdemo
        public IEnumerable<string> Get()
        {
            return bikes;      
        }

        // GET: api/bikesdemo/5
        public string Get(int id)
        {
            return bikes[id];
        }

        // POST: api/bikesdemo
        public void Post([FromBody]string value)
        {
            bikes.Add(value);
        }

        // PUT: api/bikesdemo/5
        public void Put(int id, [FromBody]string value)
        {
            bikes[id] = value;
        }

        // DELETE: api/bikesdemo/5
        public void Delete(int id)
        {
            bikes.RemoveAt(id);
        }
    }
}
