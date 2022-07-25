using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TargetDataBase.Data;
using TargetDataBase.Models;

namespace TargetDataBase.Pages.CS30s
{
    public class EditModel : PageModel
    {
        private readonly TargetDataBase.Data.TargetDataBaseContext _context;

        public EditModel(TargetDataBase.Data.TargetDataBaseContext context)
        {
            _context = context;
        }

        [BindProperty]
        public CS30 CS30 { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.CS30s == null)
            {
                return NotFound();
            }

            var cs30 =  await _context.CS30s.FirstOrDefaultAsync(m => m.ID == id);
            if (cs30 == null)
            {
                return NotFound();
            }
            CS30 = cs30;
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

            _context.Attach(CS30).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CS30Exists(CS30.ID))
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

        private bool CS30Exists(int id)
        {
          return _context.CS30s.Any(e => e.ID == id);
        }
    }
}
