using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CallCenterV1.Models
{
    public class Group
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public int  Nombre { get; set; }
        public List<Etudiant> Etudiants { get; set; }
    }
}
