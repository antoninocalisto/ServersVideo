using Microsoft.AspNetCore.Mvc;
using ServersVideo.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServersVideo.API.Controllers
{
    [Route("api/server")]
    public class ServerController: ControllerBase
    {

        [HttpGet("{serverId}")]
        public IActionResult GetById(Guid serverId)
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult Post([FromBody] CreateServerModel createServer)
        {
            //ServersController serversController = new();

            if (createServer.PortaIp > 5000)
            {
                return BadRequest();
            }

            //Cadastrar o servidor

            return CreatedAtAction(nameof(GetById), new { serverId = createServer.Id }, createServer);

        }
    }
}
