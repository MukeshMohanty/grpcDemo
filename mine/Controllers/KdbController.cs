using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace mine.Controllers
{
    [Route("api/[controller]")]
    public class KdbController : Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
            return new ObjectResult("Hello world");
        }
    }
}
