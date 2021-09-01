using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartHRMApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommonController : ControllerBase
    {
        [HttpGet]
        [Route("GetStatus")]
        public ActionResult<IEnumerable<string>> GetStatus()
        {

            var items = new List<Status>
                {
                     new Status { code = "", name = "--Select--" },
                     new Status { code = "A", name = "Active" },
                     new Status { code = "I", name = "Inactive" }
                };

            return Ok(items);
        }

        [HttpGet]
        [Route("GetStates")]
        public ActionResult<IEnumerable<string>> GetStates()
        {

            var items = new List<State>
                {
                     new State { id = 1,code = "AP", name = "Andhra Pradesh" },
                     new State { id = 2,code = "TN", name = "Tamil Nadu" }
                };

            return Ok(items);
        }

        public class Status
        {
            public string code { get; set; }
            public string name { get; set; }
        }

        public class State
        {
            public int id { get; set; }
            public string code { get; set; }
            public string name { get; set; }
        }
    }
}
