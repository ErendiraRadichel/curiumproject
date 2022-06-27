using TargetLifeCycle.Models;
using System;
using System.Linq;

namespace TargetLifeCycle.Data
{
    public class DbInitializer
    {
        public static void Initialize(CycleContex context)
        {
            context.Database.EnsureCreated();

            // Look for any targets.
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
            foreach (Target s in targets)
            {
                context.Targets.Add(s);
            }
            context.SaveChanges();

            var warehouses = new Warehouse[]
            {
            new Warehouse{WarehouseName="John D",WarehouseDate=DateTime.Parse("2022-01-01"),WarehouseLotNum=4233,WarehouseCode="W00012"},
            new Warehouse{WarehouseName="John D",WarehouseDate=DateTime.Parse("2022-01-01"),WarehouseLotNum=4233,WarehouseCode="W00012"},
            new Warehouse{WarehouseName="John D",WarehouseDate=DateTime.Parse("2022-01-01"),WarehouseLotNum=3542,WarehouseCode="W00021"}
            };
            foreach (Warehouse c in warehouses)
            {
                context.Warehouses.Add(c);
            }
            context.SaveChanges();

            var cyclotrons = new Cyclotron[]
            {
            new Cyclotron{CyclotronName="Chris C",CyclotronDate=DateTime.Parse("2022-02-01")},
            new Cyclotron{CyclotronName="Chris C",CyclotronDate=DateTime.Parse("2022-02-01")},
            new Cyclotron{CyclotronName="Chris C",CyclotronDate=DateTime.Parse("2022-02-01")}
            };
            foreach (Cyclotron e in cyclotrons)
            {
                context.Cyclotrons.Add(e);
            }
            context.SaveChanges();
        }
    }
}
