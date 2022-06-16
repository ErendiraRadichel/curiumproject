using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using APIHotProducts.Models;

namespace APIHotProducts.Data
{
    public class APIHotProductsContext : DbContext
    {
#pragma warning disable CS8618
        public APIHotProductsContext (DbContextOptions<APIHotProductsContext> options)
#pragma warning restore CS8618
            : base(options)
        {
        }

        public DbSet<APIHotProducts.Models.Target>? Target { get; set; }
    }
}
