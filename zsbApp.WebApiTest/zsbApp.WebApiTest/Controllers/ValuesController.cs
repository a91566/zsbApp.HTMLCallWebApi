using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace zsbApp.WebApiTest.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values
        //[HttpGet]
        //[EnableCors("any")]
        //public IEnumerable<string> Get1()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET api/values
        [HttpGet]
        [EnableCors("any")]
        public IActionResult Get()
        {
            dynamic x = new System.Dynamic.ExpandoObject();
            x.Code = 200;
            x.Data = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            return Json(x);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        [EnableCors("any")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        [EnableCors("any")]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        [EnableCors("any")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        [EnableCors("any")]
        public void Delete(int id)
        {
        }
    }
}
