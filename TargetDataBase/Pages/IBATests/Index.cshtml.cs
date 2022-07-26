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

        public IList<IBATest> IBATest { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.IBATests != null)
            {
                IBATest = await _context.IBATests
                .Include(i => i.IBA).ToListAsync();
            }
        }
    }
}
