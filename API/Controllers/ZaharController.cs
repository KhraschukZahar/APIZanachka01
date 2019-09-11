using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Produces("application/json")]
    [Route("api/zahar")]
    //[ApiController]
    public class ZaharController : ControllerBase
    {
       [HttpGet("get_value/{id}")]
        public IActionResult GetValue(int id)
        {
            if (id == 0)
            {
                return BadRequest("Salo");
            }

            return Ok("Zahar the best " + id);
        }

        [HttpGet("get_value")]
        public IActionResult GetValuess(int id)
        {
            if (id == 0)
            {
                return BadRequest("Salo");
            }

            return Ok("Zahar the best  SSSS");
        }
    }
}