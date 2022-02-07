using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Calculator.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AdapterController : ControllerBase
    {
        public AdapterController()
        {

        }

        [HttpGet]
        public async Task<ActionResult> GetNum()
        {
            return Ok(45);
        }
    }
}
