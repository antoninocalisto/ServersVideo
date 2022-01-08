using Microsoft.AspNetCore.Mvc;
using ServersVideo.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServersVideo.API.Controllers
{
    [Route("api/servers")]
    public class ServersController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            //Buscar todos ou filtrar
            return Ok();
        }

        [HttpGet("{serverId}")]
        public IActionResult GetById(Guid serverId)
        {
            //Buscar o servidor
            //Not found - Caso não exista um servidor

            return Ok();
        }

        [HttpPost]
        public IActionResult Post([FromBody] CreateServerModel createServer)
        {

            if (createServer.PortaIp > 5000)
            {
                return BadRequest();
            }

            //Cadastrar o servidor

            return CreatedAtAction(nameof(GetById), new { serverId = createServer.Id }, createServer);

        }

        [HttpPut("{serverId}")]
        public IActionResult Put(Guid serverId, [FromBody] UpdateServer updateServer)
        {
            if (updateServer.Nome.Length > 300)
            {
                return BadRequest();
            }

            if (updateServer.PortaIp > 500)
            {
                return BadRequest();
            }

            //Atualizo o objeto

            return NoContent();
        }

        [HttpDelete("{serverId}")]
        public IActionResult Delete(Guid serverId) 
        {
            // Buscar, se não existe, retorna NotFound

            //Remover

            return NoContent();
        }


    }
}
