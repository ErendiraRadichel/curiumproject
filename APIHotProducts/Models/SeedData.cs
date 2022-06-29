using Microsoft.EntityFrameworkCore;
using APIHotProducts.Data;

namespace APIHotProducts.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new APIHotProductsContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<APIHotProductsContext>>()))
            {
                if (context == null || context.Target == null)
                {
                    throw new ArgumentNullException("Null APIHotProductsContext");
                }

                // Look for any Targets Entries.
                if (context.Target.Any())
                {
                    return;   // DB has been seeded
                }

                context.Target.AddRange(
                    new Target
                    {
                        TargetType = "CS-30/IBA",
                        Status = "Warehouse",
                        WarehouseDate = DateTime.Now,
                        WarehouseName = "John Doe",
                        WarehouseCode = "G00027",
                        WarehouseLotNum = 12356,
                        CyclotronDate = DateTime.Now,
                        CyclotronName = "John Doe",
                        PlatingDate = DateTime.Now,
                        PlatingName = "John Doe",
                        PlatingCode = "G00010",
                        PlatingLotNum = 45236,
                        ProductName = "Ga-67",
                        TargetNum = 452,
                        BombardingDate = DateTime.Now,
                        BombardingName = "John Doe",
                        ProcessingDate = DateTime.Now,
                        ProcessingName = "John Doe"
                    },

                    new Target
                    {
                        TargetType = "CS-30/IBA",
                        Status = "Warehouse",
                        WarehouseDate = DateTime.Now,
                        WarehouseName = "John Doe",
                        WarehouseCode = "G00014",
                        WarehouseLotNum = 12356,
                        CyclotronDate = DateTime.Now,
                        CyclotronName = "John Doe",
                        PlatingDate = DateTime.Now,
                        PlatingName = "John Doe",
                        PlatingCode = "G00007",
                        PlatingLotNum = 12546,
                        ProductName = "Ga-67",
                        TargetNum = 452,
                        BombardingDate = DateTime.Now,
                        BombardingName = "John Doe",
                        ProcessingDate = DateTime.Now,
                        ProcessingName = "John Doe",
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
