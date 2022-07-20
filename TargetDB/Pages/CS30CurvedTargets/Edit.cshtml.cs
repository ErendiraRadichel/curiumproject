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

namespace TargetDB.Pages.CS30CurvedTargets
{
    public class EditModel : PageModel
    {
        private readonly TargetDB.Data.TargetContext _context;

        public EditModel(TargetDB.Data.TargetContext context)
        {
            _context = context;
        }

        [BindProperty]
        public CS30CurvedTarget CS30CurvedTarget { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.CS30CurvedTargets == null)
            {
                return NotFound();
            }

            var cs30curvedtarget =  await _context.CS30CurvedTargets.FirstOrDefaultAsync(m => m.CurvedTestID == id);
            if (cs30curvedtarget == null)
            {
                return NotFound();
            }
            CS30CurvedTarget = cs30curvedtarget;
           ViewData["CS30CurvedID"] = new SelectList(_context.CS30Curveds, "ID", "ID");
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

            _context.Attach(CS30CurvedTarget).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CS30CurvedTargetExists(CS30CurvedTarget.CurvedTestID))
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

        private bool CS30CurvedTargetExists(int id)
        {
          return _context.CS30CurvedTargets.Any(e => e.CurvedTestID == id);
        }
    }
}
