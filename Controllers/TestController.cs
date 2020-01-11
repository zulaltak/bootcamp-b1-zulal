using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace net_core_bootcamp_b1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProducController:ControllerBase
    {
        [HttpGet("Hello")]
        public IActionResult Hello()
        {
            return Ok("Hello World");
        }

    }
}
