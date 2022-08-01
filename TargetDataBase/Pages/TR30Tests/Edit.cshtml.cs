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

namespace TargetDataBase.Pages.TR30Tests
{
    public class EditModel : PageModel
    {
        private readonly TargetDataBase.Data.TargetDataBaseContext _context;

        public EditModel(TargetDataBase.Data.TargetDataBaseContext context)
        {
            _context = context;
        }

        [BindProperty]
        public TR30Test TR30Test { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.TR30Tests == null)
            {
                return NotFound();
            }

            var tr30test =  await _context.TR30Tests.FirstOrDefaultAsync(m => m.ID == id);
            if (tr30test == null)
            {
                return NotFound();
            }
            TR30Test = tr30test;
           ViewData["TR30ID"] = new SelectList(_context.TR30s, "ID", "ID");
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

            _context.Attach(TR30Test).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TR30TestExists(TR30Test.ID))
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

        private bool TR30TestExists(int id)
        {
          return _context.TR30Tests.Any(e => e.ID == id);
        }
    }
}
