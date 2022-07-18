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
                        TargetType = "CS-30(Flat)",
                        Status = "Processing",
                        WarehouseDate = DateTime.Now,
                        WarehouseName = "John Doe",
                        WarehouseCode = "G0002701",
                        WarehouseLotNum = "12356",
                        CyclotronDate = DateTime.Now,
                        CyclotronName = "John Doe",
                        CyclotronCode = "G00010 - Gold Plated",
                        Quantity = "12",
                        PlatingDate = DateTime.Now,
                        PlatingName = "John Doe",
                        PlatingCode = "S217",
                        PlatingLotNum = "45236",
                        ProductName = "Cu-64",
                        TargetNum = "452",
                        BombardingDate = DateTime.Now,
                        BombardingName = "John Doe",
                        ProcessingDate = DateTime.Now,
                        ProcessingName = "John Doe",
                        ProcessingLotNum = "01-CS-30"
                    },

                    new Target
                    {
                        TargetType = "IBA",
                        Status = "Processing",
                        WarehouseDate = DateTime.Now,
                        WarehouseName = "John Doe",
                        WarehouseCode = "J54600",
                        WarehouseLotNum = "12356",
                        CyclotronDate = DateTime.Now,
                        CyclotronName = "John Doe",
                        CyclotronCode = "J54600",
                        Quantity = "10",
                        PlatingDate = DateTime.Now,
                        PlatingName = "John Doe",
                        PlatingCode = "S790",
                        PlatingLotNum = "12546",
                        ProductName = "In-111",
                        TargetNum = "452",
                        BombardingDate = DateTime.Now,
                        BombardingName = "John Doe",
                        ProcessingDate = DateTime.Now,
                        ProcessingName = "John Doe",
                        ProcessingLotNum = "02-IBA"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
