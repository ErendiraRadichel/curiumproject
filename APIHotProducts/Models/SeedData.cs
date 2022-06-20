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
                        Status = "Warehouse",
                        CreationDate = DateTime.Now,
                        WName = "John Doe",
                        WCode = "G00027",
                        WLotNum = "L12563",
                        CDate = DateTime.Now,
                        CName = "John Doe",
                        CCode = "G00027",
                        CLotNum = "L12563",
                        C1Date = DateTime.Now,
                        C1Name = "John Doe",
                        C1Code = "G00010",
                        C1LotNum = "L56326",
                        BDate = DateTime.Now,
                        BName = "John Doe",
                        BCode = "G00010",
                        BLotNum = "L56326",
                        C2Date = DateTime.Now,
                        C2Name = "John Doe",
                        C2Code = "G00010",
                        C2LotNum = "L56326"
                    },

                    new Target
                    {
                        Product = "In-111",
                        Status = "Warehouse",
                        CreationDate = DateTime.Now,
                        WName = "John Doe",
                        WCode = "G00014",
                        WLotNum = "L12368",
                        CDate = DateTime.Now,
                        CName = "John Doe",
                        CCode = "G00014",
                        CLotNum = "L12368",
                        C1Date = DateTime.Now,
                        C1Name = "John Doe",
                        C1Code = "G00007",
                        C1LotNum = "L5466",
                        BDate = DateTime.Now,
                        BName = "John Doe",
                        BCode = "G00007",
                        BLotNum = "L5466",
                        C2Date = DateTime.Now,
                        C2Name = "John Doe",
                        C2Code = "G00007",
                        C2LotNum = "L5466"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
