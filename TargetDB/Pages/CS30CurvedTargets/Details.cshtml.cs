using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TargetDB.Data;
using TargetDB.Models;

namespace TargetDB.Pages.CS30CurvedTargets
{
    public class DetailsModel : PageModel
    {
        private readonly TargetDB.Data.TargetContext _context;

        public DetailsModel(TargetDB.Data.TargetContext context)
        {
            _context = context;
        }

      public CS30CurvedTarget CS30CurvedTarget { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.CS30CurvedTargets == null)
            {
                return NotFound();
            }

            var cs30curvedtarget = await _context.CS30CurvedTargets.FirstOrDefaultAsync(m => m.CurvedTestID == id);
            if (cs30curvedtarget == null)
            {
                return NotFound();
            }
            else 
            {
                CS30CurvedTarget = cs30curvedtarget;
            }
            return Page();
        }
    }
}
