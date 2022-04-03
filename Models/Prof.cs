using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CallCenterV1.Models
{
    public class Prof
    {
        public int Id { get; set; }
        [Display(Name = "Nom de prof")]
        public string nom { get; set; }
        public string specialite { get; set; }
        public List<ProfGroup> profGroups { get; set; }


    }
}
