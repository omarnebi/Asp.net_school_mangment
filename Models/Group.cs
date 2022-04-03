using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CallCenterV1.Models
{
    public class Group
    {

        public int Id { get; set; }
        [Display(Name ="Nom de groupe")]
        public string Nom { get; set; }
        public int  Nombre { get; set; }
        public List<Etudiant> Etudiants { get; set; }
        public List<ProfGroup> profGroups { get; set; }

      
    }
}
