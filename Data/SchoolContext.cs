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
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<ProfGroup>().HasKey(table => new {
                table.ProfID,
                table.GroupID
            });
        }
        public DbSet<Etudiant> Etudiants { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Prof> Profs { get; set; }
        public DbSet<ProfGroup> ProfGroups { get; set; }
    }
}
