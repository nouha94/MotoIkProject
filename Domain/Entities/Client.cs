using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Client :Person
    {
        public int ClientId { get; set; }
        public virtual ICollection<VehicleRequest> VehicleRequests{ get; set; }


        public Client() { }
    }
}
