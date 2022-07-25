using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TargetDataBase.Models;

namespace TargetDataBase.Data
{
    public class TargetDataBaseContext : DbContext
    {
        public TargetDataBaseContext (DbContextOptions<TargetDataBaseContext> options)
            : base(options)
        {
        }
        public DbSet<CS30> CS30s { get; set; }
        public DbSet<CS30Test> CS30Tests { get; set; }
        //public DbSet<TargetDataBase.Models.CS30> CS30 { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CS30>().ToTable("CS30");
            modelBuilder.Entity<CS30Test>().ToTable("CS30Test");
        }
    }
}
