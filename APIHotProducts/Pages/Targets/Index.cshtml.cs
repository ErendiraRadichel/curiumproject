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

        public string StatusSort { get; set; }
        public string TargetTypeSort { get; set; }
        public string ProductSort { get; set; }
        public string TargetNumSort { get; set; }
        public string WCodeSort { get; set; }
        public string PCodeSort { get; set; }
        public string WLotNumSort { get; set; }
        public string PLotNumSort { get; set; }
        public string DateSort { get; set; }
        public IList<Target> Target { get;set; } = default!;

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }

        public async Task OnGetAsync(string sortOrder, string searchString)
        {
            StatusSort = String.IsNullOrEmpty(sortOrder) ? "status_desc" : "";
            TargetTypeSort = String.IsNullOrEmpty(sortOrder) ? "targettype_desc" : "";
            ProductSort = String.IsNullOrEmpty(sortOrder) ? "productname_desc" : "";
            TargetNumSort = String.IsNullOrEmpty(sortOrder) ? "targetnum_desc" : "";
            WCodeSort = String.IsNullOrEmpty(sortOrder) ? "warehousecode_desc" : "";
            PCodeSort = String.IsNullOrEmpty(sortOrder) ? "platingcode_desc" : "";
            WLotNumSort = String.IsNullOrEmpty(sortOrder) ? "warehouselotnum_desc" : "";
            PLotNumSort = String.IsNullOrEmpty(sortOrder) ? "platinglotnum_desc" : "";
            DateSort = sortOrder == "Date" ? "date_desc" : "Date";

            searchString = SearchString;

            // Use LINQ to get list of materials.

            IQueryable<Target> targetIQ = from s in _context.Target
                                              select s;

            if (!string.IsNullOrEmpty(SearchString))
            {
                targetIQ = targetIQ.Where(s => s.WarehouseCode.Contains(searchString) || s.PlatingCode.Contains(searchString));
                //targetIQ = targetIQ.Where(s => s.TargetType.Contains(SearchString));
            }
            switch (sortOrder) 
            {
                case "status_desc":
                    targetIQ = targetIQ.OrderByDescending(s => s.Status);
                    break;
                case "targettype_desc":
                    targetIQ = targetIQ.OrderByDescending(s => s.TargetType);
                    break;
                case "productname_desc":
                    targetIQ = targetIQ.OrderByDescending(s => s.ProductName);
                    break;
                case "targetnum_desc":
                    targetIQ = targetIQ.OrderByDescending(s => s.TargetNum);
                    break;
                case "warehousecode_desc":
                    targetIQ = targetIQ.OrderByDescending(s => s.WarehouseCode);
                    break;
                case "platingcode_desc":
                    targetIQ = targetIQ.OrderByDescending(s => s.PlatingCode);
                    break;
                case "warehouselotnum_desc":
                    targetIQ = targetIQ.OrderByDescending(s => s.WarehouseLotNum);
                    break;
                case "platinglotnum_desc":
                    targetIQ = targetIQ.OrderByDescending(s => s.PlatingLotNum);
                    break;
                case "Date":
                    targetIQ = targetIQ.OrderBy(s => s.WarehouseDate);
                    break;
                default:
                    targetIQ = targetIQ.OrderBy(s => s.Status);
                    break;
            }

            var products = from m in _context.Target
                           select m;
            if (!string.IsNullOrEmpty(searchString))
            {
                products = products.Where(s => s.WarehouseCode.Contains(searchString) || s.PlatingCode.Contains(searchString));
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
