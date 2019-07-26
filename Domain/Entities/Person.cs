using Domain.Enumerations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Person 
    {
        [Key]
        public int PersonID { get; set; }

        [Required(ErrorMessage = "the name is required")]
        [MaxLength(50, ErrorMessage = "the Name must be less then 50 characters")]
        [StringLength(60)]
        public string Name { get; set; }
        [MinLength(8, ErrorMessage = "At least 8 characters are required")]
        [MaxLength(8, ErrorMessage = "At least 8 characters are required")]
        public string Cin { get; set; }
        public string Adresse { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public string UserName { get; set; }
        [DataType(DataType.Password)]

        [MinLength(8, ErrorMessage = "At least 8 characters are required")]
        public string Password { get; set; }
        [DataType(DataType.Password)]

        [Compare("Password")]
        public string VerifPassword { get; set; }
        public Role Role { get; set; }

        // [Range(10, double.MaxValue)]
        [Range(7, 100)]
        public int Age { get; set; }
        [StringLength(10)]
        public string Sex { get; set; }
       
        [DataType(DataType.Text)]
        public string Address { get; set; }
        [StringLength(15)]
        public string Nationality { get; set; }
        //public string Role { get; set; }
        [DataType(DataType.PhoneNumber)]
        public int phoneNumber { get; set; }


        public Person()
        {

        }

        public override string ToString()
        {
            return "UserName : " + UserName + "Email : " + Email + "Role : " + Role;
        }

    }
}
