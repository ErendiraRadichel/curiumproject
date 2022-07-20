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
    public class DeleteModel : PageModel
    {
        private readonly TargetDB.Data.TargetContext _context;

        public DeleteModel(TargetDB.Data.TargetContext context)
        {
            _context = context;
        }

        [BindProperty]
      public CS30Curved CS30Curved { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.CS30Curveds == null)
            {
                return NotFound();
            }

            var cs30curved = await _context.CS30Curveds.FirstOrDefaultAsync(m => m.ID == id);

            if (cs30curved == null)
            {
                return NotFound();
            }
            else 
            {
                CS30Curved = cs30curved;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.CS30Curveds == null)
            {
                return NotFound();
            }
            var cs30curved = await _context.CS30Curveds.FindAsync(id);

            if (cs30curved != null)
            {
                CS30Curved = cs30curved;
                _context.CS30Curveds.Remove(CS30Curved);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
