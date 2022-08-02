using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TargetDataBase.Data;
using TargetDataBase.Models;

namespace TargetDataBase.Pages.TR30Tests
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

        public IList<TR30Test> TR30Tests { get;set; } = default!;

        public async Task OnGetAsync(string searchString)
        {
            searchString = SearchString;

            // Use LINQ to get list of materials.
            IQueryable<TR30Test> TR30TestIQ = from s in _context.TR30Tests
                                              select s;
            if (!string.IsNullOrEmpty(SearchString))
            {
                TR30TestIQ = TR30TestIQ.Where(s => s.HNum.Contains(searchString));
            }

            TR30Tests = await TR30TestIQ.Include(c => c.TR30).AsNoTracking().ToListAsync();
        }
    }
}
