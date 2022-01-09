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

        //Criar um novo servidor
        //api/servers
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

        //Remover um servidor existente
        [HttpDelete("{serverId}")]
        public IActionResult Delete(Guid serverId)
        {
            // Buscar, se não existe, retorna NotFound

            //Remover

            return NoContent();
        }

        //Recuperar um servidor existente
        [HttpGet("{serverId}")]
        public IActionResult GetById(Guid serverId)
        {
            //Buscar o servidor
            //Not found - Caso não exista um servidor

            return Ok();

        }

        //Checar disponibilidade de um servidor
        [HttpGet("available/{serverId}")]
        public IActionResult GetAvailableServer(Guid serverId)
        {
            return Ok();
        }

        //Listar todos os servidores
        [HttpGet]
        public IActionResult GetServers()
        {
            //Buscar todos ou filtrar
            return Ok();
        }


        //Adicionar um novo vídeo à um servidor
        [HttpPost("{serverId}/videos")]
        public IActionResult PostVideo(Guid serverId, [FromBody] CreateVideoModel createVideoModel)
        {
            //Checar se existe o video

            return CreatedAtAction(nameof(GetByIdVideoServer), new { id = createVideoModel.Id }, createVideoModel);
        }

        //Remover um vídeo existente
        [HttpDelete("{serverId}/videos/{videoId}")]
        public IActionResult DeleteByIdVideo(Guid serverId, Guid videoId) 
        {
            //checar se existe servidor e se existe video (Notfound)

            return NoContent();
        }

        //Recuperar dados cadastrais de um vídeo
        [HttpGet("{serverId}/videos/{videoId}")]
        public IActionResult GetByIdVideoServer(Guid serverId, Guid videoId) 
        {

            //Verificar se existe o servidor e se existe o video.

            //retornar os dados do video
            return Ok();
        }

        //Download do conteúdo binário de um vídeo
        [HttpGet("{serverId}/videos/{videoId}/binary")]
        public IActionResult GetByIdVideoServerBinary(Guid serverId, Guid videoId)
        {
            //Verificar se existe o servidor e se existe o video. 

            //Retornar conteudo binario do video
            return Ok();
        }

        //Listar todos os vídeos de um servidor
        [HttpGet("{serverId}/videos")]
        public IActionResult GetByIdVideosServer(Guid serverId, Guid videoId)
        {
            //Verificar se existe o servidor e se existe o video. 

            //Retornar todos os videos
            return Ok();
        }

        




    }

}
