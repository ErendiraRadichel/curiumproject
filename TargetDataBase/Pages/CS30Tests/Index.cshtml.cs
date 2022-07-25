using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TargetDataBase.Data;
using TargetDataBase.Models;

namespace TargetDataBase.Pages.CS30Tests
{
    public class IndexModel : PageModel
    {
        private readonly TargetDataBase.Data.TargetDataBaseContext _context;

        public IndexModel(TargetDataBase.Data.TargetDataBaseContext context)
        {
            _context = context;
        }

        public IList<CS30Test> CS30Tests { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.CS30Tests != null)
            {
                CS30Tests = await _context.CS30Tests
                .Include(c => c.CS30).ToListAsync();
            }
        }
    }
}
