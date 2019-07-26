using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Models
{
    public class ClientModels
    {
        public int ClientId { get; set; }
        public virtual ICollection<VehicleRequest> VehicleRequests { get; set; }


    }
}