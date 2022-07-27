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
    public class DetailsModel : PageModel
    {
        private readonly TargetDataBase.Data.TargetDataBaseContext _context;

        public DetailsModel(TargetDataBase.Data.TargetDataBaseContext context)
        {
            _context = context;
        }

      public TR30 TR30 { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.TR30s == null)
            {
                return NotFound();
            }

            TR30 = await _context.TR30s
                .Include(s => s.TR30Tests)
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.ID == id);

            if (TR30 == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
