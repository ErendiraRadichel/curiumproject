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

namespace TargetDataBase.Pages.CS30Tests
{
    public class EditModel : PageModel
    {
        private readonly TargetDataBase.Data.TargetDataBaseContext _context;

        public EditModel(TargetDataBase.Data.TargetDataBaseContext context)
        {
            _context = context;
        }

        [BindProperty]
        public CS30Test CS30Test { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.CS30Tests == null)
            {
                return NotFound();
            }

            var cs30test =  await _context.CS30Tests.FirstOrDefaultAsync(m => m.ID == id);
            if (cs30test == null)
            {
                return NotFound();
            }
            CS30Test = cs30test;
           ViewData["CS30ID"] = new SelectList(_context.CS30s, "ID", "ID");
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

            _context.Attach(CS30Test).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CS30TestExists(CS30Test.ID))
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

        private bool CS30TestExists(int id)
        {
          return _context.CS30Tests.Any(e => e.ID == id);
        }
    }
}
