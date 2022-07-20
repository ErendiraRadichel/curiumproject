using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TargetDB.Data;
using TargetDB.Models;

namespace TargetDB.Pages.CS30Curveds
{
    public class EditModel : PageModel
    {
        private readonly TargetDB.Data.TargetContext _context;

        public EditModel(TargetDB.Data.TargetContext context)
        {
            _context = context;
        }

        [BindProperty]
        public CS30Curved CS30Curved { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.CS30Curveds == null)
            {
                return NotFound();
            }

            var cs30curved =  await _context.CS30Curveds.FirstOrDefaultAsync(m => m.ID == id);
            if (cs30curved == null)
            {
                return NotFound();
            }
            CS30Curved = cs30curved;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(CS30Curved).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CS30CurvedExists(CS30Curved.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool CS30CurvedExists(int id)
        {
          return _context.CS30Curveds.Any(e => e.ID == id);
        }
    }
}
