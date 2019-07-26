using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.Models
{
    [Bind(Exclude = "OrderID")]
    public class VehicleModels
    {
        [Key]
        //[StringLength(12)]
        public int ID { get; set; }
        public string Marque { get; set; }
        public string Kilometrage { get; set; }
        public string Matricule { get; set; }
        public VehiclePays Pays { get; set; }
        public VehicleCouleur Couleur { get; set; }
    }
}