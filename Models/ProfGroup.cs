using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CallCenterV1.Models
{
    public class ProfGroup
    {
        [Key]
        [Column(Order =1)]
      public int ProfID { get; set; }
        [Key]
        [Column(Order = 2)]
        public int GroupID { get; set; }
      public virtual Group Group { get; set; }
      public virtual Prof Prof { get; set; }
    }
}
