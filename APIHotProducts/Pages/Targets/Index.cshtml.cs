using System;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using APIHotProducts.Data;
using APIHotProducts.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace APIHotProducts.Pages.Targets
{
#pragma warning disable CS8618
#pragma warning disable CS8604
    public class IndexModel : PageModel
    {
        private readonly APIHotProducts.Data.APIHotProductsContext _context;

        public IndexModel(APIHotProducts.Data.APIHotProductsContext context)
        {
            _context = context;
        }

        public string ProductSort { get; set; }
        public string DateSort { get; set; }
        public string CodeSort { get; set; }
        public IList<Target> Target { get;set; } = default!;

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }

        public async Task OnGetAsync(string sortOrder, string searchString)
        {
            ProductSort = String.IsNullOrEmpty(sortOrder) ? "product_desc" : "";
            DateSort = sortOrder == "Date" ? "date_desc" : "Date";
            CodeSort = String.IsNullOrEmpty(sortOrder) ? "code_desc" : "";

            searchString = SearchString;

            // Use LINQ to get list of materials.

            IQueryable<Target> targetIQ = from s in _context.Target
                                              select s;

            if (!string.IsNullOrEmpty(SearchString))
            {
                targetIQ = targetIQ.Where(s => s.WCode.Contains(SearchString));
                //targetIQ = targetIQ.Where(s => s.TargetType.Contains(SearchString));
            }
            switch (sortOrder) 
            {
                case "product_desc":
                    targetIQ = targetIQ.OrderByDescending(s => s.Product);
                    break;
                case "Date":
                    targetIQ = targetIQ.OrderBy(s => s.CreationDate);
                    break;
                case "code_desc":
                    targetIQ = targetIQ.OrderByDescending(s => s.WCode);
                    break;
                default:
                    targetIQ = targetIQ.OrderBy(s => s.Product);
                    break;
            }

            var products = from m in _context.Target
                           select m;
            if (!string.IsNullOrEmpty(searchString))
            {
                products = products.Where(s => s.WCode.Contains(searchString) || s.CCode.Contains(searchString) || s.C1Code.Contains(searchString) || s.BCode.Contains(searchString) || s.C2Code.Contains(searchString));
                //products = products.Where(s => s.TargetType!.Contains(searchString));
            }
            if (_context.Target != null)
            {
                Target = await _context.Target.ToListAsync();
            }

            //Target = await products.ToListAsync();
            Target = await targetIQ.AsNoTracking().ToListAsync();
        }
    }
#pragma warning restore CS8618
#pragma warning restore CS8604
}
