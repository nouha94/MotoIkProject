using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
   public class Vehicle
    {
        public Vehicle()
        {

        }
        [Key]
        public int ID { get; set; }
        public string Marque { get; set; }
        public string Kilometrage { get; set; }
        public string Matricule { get; set; }
        public VehiclePays Pays{ get; set; }
        public VehicleCouleur Couleur { get; set; }

    }
}
