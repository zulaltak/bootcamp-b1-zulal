using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using net_core_bootcamp_b1.DTOs;
using net_core_bootcamp_b1.Services;
using System;
using System.Collections.Generic;

namespace net_core_bootcamp_b1.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [Consumes("application/json")]
    [ApiController]
    public class HWEventController : ControllerBase
    {
        private readonly IHWEventService _hweventService;

        public HWEventController(IHWEventService hweventService) // Hocaya sor!
        {
            _hweventService = hweventService;
        }

        [HttpPost("Add")]
        public IActionResult Add([FromBody]HWEventAddDto model)
        {
            var _result = _hweventService.Add(model);

            return Ok(_result);
        }

        [HttpGet("Get")]
        [ProducesResponseType(typeof(IList<HWEventGetDto>), 200)]
        public IActionResult Get()
        {
            var _result = _hweventService.Get();

            return Ok(_result);
        }

        [HttpPut("Update")]
        public IActionResult Update([FromBody]HWEventUpDateDto model)
        {
            var _result = _hweventService.UpDate(model);

            return Ok(_result);
        }

        [HttpDelete("Delete")]
        public IActionResult Delete([BindRequired]Guid Id)
        {
            var _result = _hweventService.Delete(Id);

            return Ok(_result);
        }
    }
}
