using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PiePizza4.Models
{
    public class ApplicationUser
    {

        [Display(Name = "Sales")]
        public string Name { get; set; }

        [NotMapped]
        public bool IsSuperAdmin { get; set; }


    }
}
