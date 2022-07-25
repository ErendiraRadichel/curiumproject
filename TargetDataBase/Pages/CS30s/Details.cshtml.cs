using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TargetDataBase.Data;
using TargetDataBase.Models;

namespace TargetDataBase.Pages.CS30s
{
    public class DetailsModel : PageModel
    {
        private readonly TargetDataBase.Data.TargetDataBaseContext _context;

        public DetailsModel(TargetDataBase.Data.TargetDataBaseContext context)
        {
            _context = context;
        }

      public CS30 CS30 { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.CS30s == null)
            {
                return NotFound();
            }

            CS30 = await _context.CS30s
                .Include(s => s.CS30Tests)
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.ID == id);

            if (CS30 == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
