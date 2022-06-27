using TargetLifeCycle.Models;
using System;
using System.Linq;

namespace TargetLifeCycle.Data
{
    public class DbInitializer
    {
        public static void Initialize(CycleContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Targets.Any())
            {
                return;   // DB has been seeded
            }

            var targets = new Target[]
            {
            new Target{TargetType="CS-30/IBA",Status="Warehouse"},
            new Target{TargetType="CS-30/IBA",Status="Warehouse"},
            new Target{TargetType="CS-30(flat)",Status="Cyclotron Spares"}
            };
            foreach (Target t in targets)
            {
                context.Targets.Add(t);
            }
            context.SaveChanges();

            var warehouses = new Warehouse[]
            {
            new Warehouse{WarehouseCode="W00012",WarehouseLotNum=1256,WarehouseName="John D",WarehouseDate=DateTime.Parse("2022-01-01")},
            new Warehouse{WarehouseCode="W00023",WarehouseLotNum=1256,WarehouseName="John D",WarehouseDate=DateTime.Parse("2022-01-01")},
            new Warehouse{WarehouseCode="W00012",WarehouseLotNum=1256,WarehouseName="John D", WarehouseDate = DateTime.Parse("2022-01-01")},
            };
            foreach (Warehouse w in warehouses)
            {
                context.Warehouses.Add(w);
            }
            context.SaveChanges();

            var cyclotrons = new Cyclotron[]
            {
            new Cyclotron{CyclotronName="Ed D",CyclotronDate=DateTime.Parse("2022-01-12")},
            new Cyclotron{CyclotronName="Ed D",CyclotronDate=DateTime.Parse("2022-01-12")},
            new Cyclotron{CyclotronName="Ed D",CyclotronDate=DateTime.Parse("2022-01-12")},
            };
            foreach (Cyclotron c in cyclotrons)
            {
                context.Cyclotrons.Add(c);
            }
            context.SaveChanges();
        }
    }
}
