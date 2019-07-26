using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Web.Models
{
    public class VehicleResquestModels
    {
        [Key]
        //[StringLength(12)]
        public int ID { get; set; }
        public string NameR { get; set; }

        public string Marque { get; set; }
        public string Kilometrage { get; set; }
        public string Matricule { get; set; }
        public int? ClientId { get; set; }
        //nav
        [ForeignKey("ClientId")]
        public virtual Client Client { get; set; }

    }
}