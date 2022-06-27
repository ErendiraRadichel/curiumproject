using TargetLifeCycle.Models;
using Microsoft.EntityFrameworkCore;

namespace TargetLifeCycle.Data
{
    public class CycleContex : DbContext
    {
        public CycleContex(DbContextOptions<CycleContex> options) : base(options)
            { }
        public DbSet<Cyclotron> Cyclotrons { get; set; }
        public DbSet<Warehouse> Warehouses { get; set; }
        public DbSet<Target> Targets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cyclotron>().ToTable("Cyclotron");
            modelBuilder.Entity<Warehouse>().ToTable("Warehouse");
            modelBuilder.Entity<Target>().ToTable("Target");
        }
    }
}
