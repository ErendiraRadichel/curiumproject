using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TargetDB.Models;

namespace TargetDB.Data
{
    public class TargetContext : DbContext
    {
        public TargetContext(DbContextOptions<TargetContext> options)
            : base(options)
        {
        }
        public DbSet<CS30Curved> CS30Curveds { get; set; }
        public DbSet<CS30CurvedTarget> CS30CurvedTargets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CS30Curved>().ToTable("CS30Curved");
            modelBuilder.Entity<CS30CurvedTarget>().ToTable("CS30CurvedTarget");
        }

        //public DbSet<TargetDB.Models.CS30Curved> CS30Curved { get; set; } = default!;
    }
}
