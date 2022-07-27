using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TargetDataBase.Data;
using TargetDataBase.Models;

namespace TargetDataBase.Pages.TR30s
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
        public string WFCSort { get; set; }
        public string WBCSort { get; set; }
        public string CFCSort { get; set; }
        public string CBCSort { get; set; }
        public string PCodeSort { get; set; }
        public string WFLotNumSort { get; set; }
        public string WBLotNumSort { get; set; }
        public string PLotNumSort { get; set; }
        public string ProcessLotNumSort { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public IList<TR30> TR30s { get;set; } = default!;

        public async Task OnGetAsync(string sortOrder, string searchString)
        {
            StatusSort = String.IsNullOrEmpty(sortOrder) ? "status_desc" : "";
            ProductSort = String.IsNullOrEmpty(sortOrder) ? "productname_desc" : "";
            TargetNumSort = String.IsNullOrEmpty(sortOrder) ? "targetnum_desc" : "";
            WFCSort = String.IsNullOrEmpty(sortOrder) ? "wfacecode_desc" : "";
            WBCSort = String.IsNullOrEmpty(sortOrder) ? "wbodycode_desc" : "";
            CFCSort = String.IsNullOrEmpty(sortOrder) ? "cfacecode_desc" : "";
            CBCSort = String.IsNullOrEmpty(sortOrder) ? "cbodycode_desc" : "";
            PCodeSort = String.IsNullOrEmpty(sortOrder) ? "platingcode_desc" : "";
            WFLotNumSort = String.IsNullOrEmpty(sortOrder) ? "wfacelotnum_desc" : "";
            WBLotNumSort = String.IsNullOrEmpty(sortOrder) ? "wbodylotnum_desc" : "";
            PLotNumSort = String.IsNullOrEmpty(sortOrder) ? "platinglotnum_desc" : "";
            ProcessLotNumSort = String.IsNullOrEmpty(sortOrder) ? "processlotnum_desc" : "";

            searchString = SearchString;

            // Use LINQ to get list of materials.
            IQueryable<TR30> TR30IQ = from s in _context.TR30s
                                    select s;
            if (!string.IsNullOrEmpty(SearchString))
            {
                TR30IQ = TR30IQ.Where(s => s.WFaceCode.Contains(searchString) || s.WBodyCode.Contains(searchString) || s.PlatingCode.Contains(searchString) || s.Status.Contains(searchString) ||
                s.ProductName.Contains(searchString) || s.ProcessingLotNum.Contains(searchString) || s.TargetNum.Contains(searchString) || s.WFaceLotNum.Contains(searchString) || s.WBodyLotNum.Contains(searchString) ||
                s.PlatingLotNum.Contains(searchString) || s.CFaceCode.Contains(searchString) || s.CBodyCode.Contains(searchString));
            }

            switch (sortOrder)
            {
                case "status_desc":
                    TR30IQ = TR30IQ.OrderByDescending(s => s.Status);
                    break;
                case "productname_desc":
                    TR30IQ = TR30IQ.OrderByDescending(s => s.ProductName);
                    break;
                case "targetnum_desc":
                    TR30IQ = TR30IQ.OrderByDescending(s => s.TargetNum);
                    break;
                case "wfacecode_desc":
                    TR30IQ = TR30IQ.OrderByDescending(s => s.WFaceCode);
                    break;
                case "wbodycode_desc":
                    TR30IQ = TR30IQ.OrderByDescending(s => s.WBodyCode);
                    break;
                case "cfacecode_desc":
                    TR30IQ = TR30IQ.OrderByDescending(s => s.CFaceCode);
                    break;
                case "cbodycode_desc":
                    TR30IQ = TR30IQ.OrderByDescending(s => s.CBodyCode);
                    break;
                case "platingcode_desc":
                    TR30IQ = TR30IQ.OrderByDescending(s => s.PlatingCode);
                    break;
                case "wfacelotnum_desc":
                    TR30IQ = TR30IQ.OrderByDescending(s => s.WFaceLotNum);
                    break;
                case "wbodylotnum_desc":
                    TR30IQ = TR30IQ.OrderByDescending(s => s.WBodyLotNum);
                    break;
                case "platinglotnum_desc":
                    TR30IQ = TR30IQ.OrderByDescending(s => s.PlatingLotNum);
                    break;
                case "processlotnum_desc":
                    TR30IQ = TR30IQ.OrderByDescending(s => s.ProcessingLotNum);
                    break;
                default:
                    TR30IQ = TR30IQ.OrderBy(s => s.Status);
                    break;
            }
            TR30s = await TR30IQ.AsNoTracking().ToListAsync();
        }
    }
}
