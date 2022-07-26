using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TargetDataBase.Data;
using TargetDataBase.Models;

namespace TargetDataBase.Pages.IBATests
{
    public class IndexModel : PageModel
    {
        private readonly TargetDataBase.Data.TargetDataBaseContext _context;

        public IndexModel(TargetDataBase.Data.TargetDataBaseContext context)
        {
            _context = context;
        }

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }

        public IList<IBATest> IBATests { get;set; } = default!;

        public async Task OnGetAsync(string searchString)
        {
            searchString = SearchString;

            // Use LINQ to get list of materials.
            IQueryable<IBATest> IBATestIQ = from s in _context.IBATests
                                              select s;
            if (!string.IsNullOrEmpty(SearchString))
            {
                IBATestIQ = IBATestIQ.Where(s => s.HNum.Contains(searchString));
            }

            IBATests = await IBATestIQ.Include(c => c.IBA).AsNoTracking().ToListAsync();
        }
    }
}
