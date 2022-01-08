using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServersVideo.API.Models
{
    public class CreateServerModel
    {
        public Guid Id { get; set; }

        public String Nome { get; set; }

        public String EnderecoIP { get; set; }

        public int PortaIp { get; set; }
    }
}
