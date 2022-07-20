using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TargetDB.Data;
using TargetDB.Models;

namespace TargetDB.Pages.CS30Curveds
{
    public class IndexModel : PageModel
    {
        private readonly TargetDB.Data.TargetContext _context;

        public IndexModel(TargetDB.Data.TargetContext context)
        {
            _context = context;
        }

        public string StatusSort { get; set; }
        public string WCodeSort { get; set; }
        public string WLotNumSort { get; set; }
        public string Search { get; set; }
        public string ProductSort { get; set; }
        public string TargetNumSort { get; set; }
        public string CCodeSort { get; set; }
        public string PCodeSort { get; set; }
        public string PLotNumSort { get; set; }
        public string ProcessLotNumSort { get; set; }
        public IList<CS30Curved> CS30Curveds { get;set; } = default!;

        public async Task OnGetAsync(string sortOrder, string searchString)
        {
            // using System;
            StatusSort = String.IsNullOrEmpty(sortOrder) ? "Status_desc" : "";
            WCodeSort = String.IsNullOrEmpty(sortOrder) ? "WCode_desc" : "";
            WLotNumSort = String.IsNullOrEmpty(sortOrder) ? "WLotNum_desc" : "";
            ProductSort = String.IsNullOrEmpty(sortOrder) ? "productname_desc" : "";
            TargetNumSort = String.IsNullOrEmpty(sortOrder) ? "targetnum_desc" : "";
            PCodeSort = String.IsNullOrEmpty(sortOrder) ? "platingcode_desc" : "";
            PLotNumSort = String.IsNullOrEmpty(sortOrder) ? "platinglotnum_desc" : "";
            ProcessLotNumSort = String.IsNullOrEmpty(sortOrder) ? "processlotnum_desc" : "";

            Search = searchString;

            IQueryable<CS30Curved> CS30IQ = from s in _context.CS30Curveds
                                             select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                CS30IQ = CS30IQ.Where(s => s.WarehouseCode.Contains(searchString) || s.PlatingCode.Contains(searchString) || s.Status.Contains(searchString) ||
                s.ProductName.Contains(searchString) || s.ProcessingLotNum.Contains(searchString) || s.TargetNum.Contains(searchString) || s.WarehouseLotNum.Contains(searchString) ||
                s.PlatingLotNum.Contains(searchString));
            }
            switch (sortOrder)
            {
                case "Status_desc":
                    CS30IQ = CS30IQ.OrderByDescending(s => s.Status);
                    break;
                case "WCode_desc":
                    CS30IQ = CS30IQ.OrderByDescending(s => s.WarehouseCode);
                    break;
                case "WLotNum_desc":
                    CS30IQ = CS30IQ.OrderByDescending(s => s.WarehouseLotNum);
                    break;
                case "productname_desc":
                    CS30IQ = CS30IQ.OrderByDescending(s => s.ProductName);
                    break;
                case "targetnum_desc":
                    CS30IQ = CS30IQ.OrderByDescending(s => s.TargetNum);
                    break;
                case "platingcode_desc":
                    CS30IQ = CS30IQ.OrderByDescending(s => s.PlatingCode);
                    break;
                case "platinglotnum_desc":
                    CS30IQ = CS30IQ.OrderByDescending(s => s.PlatingLotNum);
                    break;
                case "processlotnum_desc":
                    CS30IQ = CS30IQ.OrderByDescending(s => s.ProcessingLotNum);
                    break;
                default:
                    CS30IQ = CS30IQ.OrderBy(s => s.Status);
                    break;
            }
            CS30Curveds = await CS30IQ.AsNoTracking().ToListAsync();
        }
    }
}
