﻿using TargetDB.Models;
using System;
using System.Linq;

namespace TargetDB.Data
{
    public static class DbInitializer
    {
        public static void Initialize(CycleContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Targets.Any())
            {
                return;   // DB has been seeded
            }

            var students = new Target[]
            {
            new Target{TargetType="CS-30/IBA",Status="Warehouse"},
            new Target{TargetType="CS-30/IBA",Status="Warehouse"},
            new Target{TargetType="CS-30(flat)",Status="Cyclotron Spares"}
            };
            context.SaveChanges();

            var warehouses = new Warehouse[]
            {
            new Warehouse{WCode="W00012",WLotNum=1256,WarehouseName="John D",WarehouseDate=DateTime.Parse("2022-01-01")},
            new Warehouse{WCode="W00023",WLotNum=1256,WarehouseName="John D",WarehouseDate=DateTime.Parse("2022-01-01")},
            new Warehouse{WCode="W00012",WLotNum=1256,WarehouseName="John D", WarehouseDate = DateTime.Parse("2022-01-01")},
            };
            context.SaveChanges();

            var cyclotrons = new Cyclotron[]
            {
            new Cyclotron{CyclotronName="Ed D",CyclotronDate=DateTime.Parse("2022-01-12")},
            new Cyclotron{CyclotronName="Ed D",CyclotronDate=DateTime.Parse("2022-01-12")},
            new Cyclotron{CyclotronName="Ed D",CyclotronDate=DateTime.Parse("2022-01-12")},
            
            };
            context.SaveChanges();
        }
    }
}
