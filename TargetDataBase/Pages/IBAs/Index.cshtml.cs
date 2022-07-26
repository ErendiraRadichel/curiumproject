using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TargetDataBase.Data;
using TargetDataBase.Models;

namespace TargetDataBase.Pages.IBAs
{
    public class IndexModel : PageModel
    {
        private readonly TargetDataBase.Data.TargetDataBaseContext _context;

        public IndexModel(TargetDataBase.Data.TargetDataBaseContext context)
        {
            _context = context;
        }

        public string StatusSort { get; set; }
        public string TargetTypeSort { get; set; }
        public string ProductSort { get; set; }
        public string TargetNumSort { get; set; }
        public string WCodeSort { get; set; }
        public string CCodeSort { get; set; }
        public string PCodeSort { get; set; }
        public string WLotNumSort { get; set; }
        public string PLotNumSort { get; set; }
        public string ProcessLotNumSort { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public IList<IBA> IBAs { get;set; } = default!;

        public async Task OnGetAsync(string sortOrder, string searchString)
        {
            StatusSort = String.IsNullOrEmpty(sortOrder) ? "status_desc" : "";
            ProductSort = String.IsNullOrEmpty(sortOrder) ? "productname_desc" : "";
            TargetNumSort = String.IsNullOrEmpty(sortOrder) ? "targetnum_desc" : "";
            WCodeSort = String.IsNullOrEmpty(sortOrder) ? "warehousecode_desc" : "";
            CCodeSort = String.IsNullOrEmpty(sortOrder) ? "cyclocode_desc" : "";
            PCodeSort = String.IsNullOrEmpty(sortOrder) ? "platingcode_desc" : "";
            WLotNumSort = String.IsNullOrEmpty(sortOrder) ? "warehouselotnum_desc" : "";
            PLotNumSort = String.IsNullOrEmpty(sortOrder) ? "platinglotnum_desc" : "";
            ProcessLotNumSort = String.IsNullOrEmpty(sortOrder) ? "processlotnum_desc" : "";

            searchString = SearchString;

            // Use LINQ to get list of materials.
            IQueryable<IBA> IBAIQ = from s in _context.IBAs
                                      select s;

            if (!string.IsNullOrEmpty(SearchString))
            {
                IBAIQ = IBAIQ.Where(s => s.WarehouseCode.Contains(searchString) || s.PlatingCode.Contains(searchString) || s.Status.Contains(searchString) ||
                s.ProductName.Contains(searchString) || s.ProcessingLotNum.Contains(searchString) || s.TargetNum.Contains(searchString) || s.WarehouseLotNum.Contains(searchString) ||
                s.PlatingLotNum.Contains(searchString) || s.CyclotronCode.Contains(searchString));
            }

            switch (sortOrder)
            {
                case "status_desc":
                    IBAIQ = IBAIQ.OrderByDescending(s => s.Status);
                    break;
                case "productname_desc":
                    IBAIQ = IBAIQ.OrderByDescending(s => s.ProductName);
                    break;
                case "targetnum_desc":
                    IBAIQ = IBAIQ.OrderByDescending(s => s.TargetNum);
                    break;
                case "warehousecode_desc":
                    IBAIQ = IBAIQ.OrderByDescending(s => s.WarehouseCode);
                    break;
                case "cyclocode_desc":
                    IBAIQ = IBAIQ.OrderByDescending(s => s.CyclotronCode);
                    break;
                case "platingcode_desc":
                    IBAIQ = IBAIQ.OrderByDescending(s => s.PlatingCode);
                    break;
                case "warehouselotnum_desc":
                    IBAIQ = IBAIQ.OrderByDescending(s => s.WarehouseLotNum);
                    break;
                case "platinglotnum_desc":
                    IBAIQ = IBAIQ.OrderByDescending(s => s.PlatingLotNum);
                    break;
                case "processlotnum_desc":
                    IBAIQ = IBAIQ.OrderByDescending(s => s.ProcessingLotNum);
                    break;
                default:
                    IBAIQ = IBAIQ.OrderBy(s => s.Status);
                    break;
            }
            IBAs = await IBAIQ.AsNoTracking().ToListAsync();
        }
    }
}
