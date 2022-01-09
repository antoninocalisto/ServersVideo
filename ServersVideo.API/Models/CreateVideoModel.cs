using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServersVideo.API.Models
{
    public class CreateVideoModel
    {
        public Guid Id { get; set; }

        public string Description { get; set; }

        public int SizeInBytes { get; set; }

        public DateTime DataCriacao { get; set; } = DateTime.Now;

        public string Status { get; set; } = "running";
    }
}
