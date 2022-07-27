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
        public DbSet<IBA> IBAs { get; set; }
        public DbSet<IBATest> IBATests { get; set; }
        public DbSet<TR30> TR30s { get; set; }
        public DbSet<TR30Test> TR30Tests { get; set; }
        //public DbSet<TargetDataBase.Models.CS30> CS30 { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CS30>().ToTable("CS30");
            modelBuilder.Entity<CS30Test>().ToTable("CS30Test");
            modelBuilder.Entity<IBA>().ToTable("IBA");
            modelBuilder.Entity<IBATest>().ToTable("IBATest");
            modelBuilder.Entity<TR30>().ToTable("TR30");
            modelBuilder.Entity<TR30Test>().ToTable("TR30Test");
        }
        //public DbSet<TargetDataBase.Models.CS30> CS30 { get; set; } = default!;
        //public DbSet<TargetDataBase.Models.TR30> TR30 { get; set; }
    }
}
