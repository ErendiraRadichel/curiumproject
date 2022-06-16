using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using APIHotProducts.Data;
using APIHotProducts.Models;

namespace APIHotProducts.Pages.Targets
{
    public class EditModel : PageModel
    {
        private readonly APIHotProducts.Data.APIHotProductsContext _context;

        public EditModel(APIHotProducts.Data.APIHotProductsContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Target Target { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Target == null)
            {
                return NotFound();
            }

            var target =  await _context.Target.FirstOrDefaultAsync(m => m.ID == id);
            if (target == null)
            {
                return NotFound();
            }
            Target = target;
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

            _context.Attach(Target).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TargetExists(Target.ID))
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

        private bool TargetExists(int id)
        {
          return (_context.Target?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}
