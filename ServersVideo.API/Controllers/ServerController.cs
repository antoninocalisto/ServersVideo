using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServersVideo.API.Controllers
{
    [Route("api/server")]
    public class ServerController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post()
        {
            return Ok(201);

        }

    }
}
