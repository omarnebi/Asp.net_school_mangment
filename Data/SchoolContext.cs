using CallCenterV1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CallCenterV1.Data
{
    public class SchoolContext: DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options)
            : base(options)
        {
           
        }
        public DbSet<Etudiant> Etudiants { get; set; }
        public DbSet<Group> Groups { get; set; }
    }
}
