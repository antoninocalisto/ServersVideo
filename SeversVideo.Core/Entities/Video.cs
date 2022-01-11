using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeversVideo.Core.Entities
{
    class Video : BaseEntity
    {
        public Video(string description, int sizeInByte)
        {
            DataCriacao = DateTime.Now;
            Status = "running";
            Description = description;
            SizeInBytes = sizeInByte;
        }


        public Guid IdServer { get; private set; }

        public string Description { get; private set; }

        public int SizeInBytes { get; private set; }

        public DateTime DataCriacao { get; private set; }

        public string Status { get; set; }
    }
}
