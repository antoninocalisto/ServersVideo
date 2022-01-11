using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeversVideo.Core.Entities
{
    class Server : BaseEntity
    {
        public Server()
        {
            
            CreateAt = DateTime.Now;
            Active = true;

            Videos = new List<Video>();
            
        }

        public DateTime CreateAt { get; private set; }

        public List<Video> Videos { get; private set; }




    }
}
