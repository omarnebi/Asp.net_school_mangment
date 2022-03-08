using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace CallCenterV1.Models
{
    // cette classe hérite tous les champs de identity user. Lorsque on ajoute des nouveaux champs, 
    // la table  USER dans la base sera modifié 
    public class ApplicationUser:IdentityUser
    {
        [Required, MaxLength(100)]
        public string FirstName { get; set; }

        [Required, MaxLength(100)]
        public string LastName { get; set; }

        
    }
}
