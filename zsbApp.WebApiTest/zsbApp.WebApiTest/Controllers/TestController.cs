using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace zsbApp.WebApiTest.Controllers
{
    public class TestController : Controller
    {
        [HttpGet]
        [EnableCors("any")]
        public IActionResult Index()
        {
            dynamic x = new System.Dynamic.ExpandoObject();
            x.Code = 200;
            x.Data = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            return Json(x);
        }
    }
}