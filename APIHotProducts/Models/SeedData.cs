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
                        Product = "Ga-67",
                        Code = "S732",
                        LotNum = 123,
                        TargetType = "CS-30/IBA",
                        Date = DateTime.Now,
                        Description = "",
                        Status = "In Warehouse"
                    },

                    new Target
                    {
                        Product = "Ga-67",
                        Code = "S732",
                        LotNum = 123,
                        TargetType = "CS-30/IBA",
                        Date = DateTime.Now,
                        Description = "",
                        Status = "In Warehouse"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
