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

namespace TargetDataBase.Pages.IBATests
{
    public class EditModel : PageModel
    {
        private readonly TargetDataBase.Data.TargetDataBaseContext _context;

        public EditModel(TargetDataBase.Data.TargetDataBaseContext context)
        {
            _context = context;
        }

        [BindProperty]
        public IBATest IBATest { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.IBATests == null)
            {
                return NotFound();
            }

            var ibatest =  await _context.IBATests.FirstOrDefaultAsync(m => m.ID == id);
            if (ibatest == null)
            {
                return NotFound();
            }
            IBATest = ibatest;
           ViewData["IBAID"] = new SelectList(_context.IBAs, "ID", "ID");
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

            _context.Attach(IBATest).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!IBATestExists(IBATest.ID))
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

        private bool IBATestExists(int id)
        {
          return _context.IBATests.Any(e => e.ID == id);
        }
    }
}
