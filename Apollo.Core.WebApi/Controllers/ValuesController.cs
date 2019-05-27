using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Com.Ctrip.Framework.Apollo;
using Com.Ctrip.Framework.Apollo.Model;

namespace Apollo.Core.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private IConfiguration _configuration;

        public ValuesController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
      
        // GET api/values/5
        [HttpGet]
        public ActionResult<string> Get(string key)
        {
           
            string title = _configuration.GetValue<string>("dev_test");
            return title;
        }

     

    }
}
