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
                        CreationDate = DateTime.Now,
                        WName = "John Doe",
                        WStatus = "Warehouse",
                        WCode = "G00027",
                        WLotNum = "L12563",
                        CDate = DateTime.Now,
                        CName = "John Doe",
                        CStatus = "Cyclotron Spares",
                        CCode = "G00027",
                        CLotNum = "L12563",
                        C1Date = DateTime.Now,
                        C1Name = "John Doe",
                        C1Status = "Chemistry Lab 1",
                        C1Code = "G00010",
                        C1LotNum = "L56326",
                        BDate = DateTime.Now,
                        BName = "John Doe",
                        BStatus = "Bombarding",
                        BCode = "G00010",
                        BLotNum = "L56326",
                        C2Date = DateTime.Now,
                        C2Name = "John Doe",
                        C2Status = "Chemistry Lab 2",
                        C2Code = "G00010",
                        C2LotNum = "L56326"
                    },

                    new Target
                    {
                        Product = "In-111",
                        CreationDate = DateTime.Now,
                        WName = "John Doe",
                        WStatus = "Warehouse",
                        WCode = "G00014",
                        WLotNum = "L12368",
                        CDate = DateTime.Now,
                        CName = "John Doe",
                        CStatus = "Cyclotron Spares",
                        CCode = "G00014",
                        CLotNum = "L12368",
                        C1Date = DateTime.Now,
                        C1Name = "John Doe",
                        C1Status = "Chemistry Lab 1",
                        C1Code = "G00007",
                        C1LotNum = "L5466",
                        BDate = DateTime.Now,
                        BName = "John Doe",
                        BStatus = "Bombarding",
                        BCode = "G00007",
                        BLotNum = "L5466",
                        C2Date = DateTime.Now,
                        C2Name = "John Doe",
                        C2Status = "Chemistry Lab 2",
                        C2Code = "G00007",
                        C2LotNum = "L5466"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
