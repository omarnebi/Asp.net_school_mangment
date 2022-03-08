using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CallCenterV1.Models
{
    public class Etudiant
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string prenomn { get; set; }
        public DateTime DateNaissiance { get; set; }
        public DateTime AnneBac { get; set; }
        public String Niveau { get; set; }
        public String Specialite { get; set; }
        public String Image { get; set; }
        [ForeignKey("Groupe")]
        public int IDGroupe { get; set; }
        public Group Group { get; set; }
    }
}
