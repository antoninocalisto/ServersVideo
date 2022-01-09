using Microsoft.AspNetCore.Mvc;
using ServersVideo.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServersVideo.API.Controllers
{
    [Route("api/recycler")]
    public class RecyclerController : ControllerBase
    {
        //Reciclar vídeos antigos pela quantidade de dias
        [HttpDelete("process/{days}")]
        public IActionResult DeleteRecyclerVideoDays(int days) 
        {
            //Verificar os videos que estão com a quantidade de x dias e excluí-los
            
            return Accepted();
        }

        //Reciclar vídeos antigos pelo status
        [HttpDelete("status")]
        public IActionResult GetRecyclerVideoStatus([FromBody] CreateRecyclerModel createRecyclerModel)
        {
            //Verificar qual o status que está sendo passado no corpo do json e apagar os videos com esse status
            
            return Accepted();
        }
    }
}
