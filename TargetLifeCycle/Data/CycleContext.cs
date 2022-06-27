using TargetLifeCycle.Models;
using Microsoft.EntityFrameworkCore;

namespace TargetLifeCycle.Data
{
    public class CycleContext : DbContext
    {
        public CycleContext(DbContextOptions<CycleContext> options) : base(options)
        { }

        public DbSet<Target> Targets { get; set; }
        public DbSet<Warehouse> Warehouses { get; set; }
        public DbSet<Cyclotron> Cyclotrons { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Target>().ToTable("Target");
            modelBuilder.Entity<Warehouse>().ToTable("Warehouse");
            modelBuilder.Entity<Cyclotron>().ToTable("Cyclotron");
        }
    }
}
