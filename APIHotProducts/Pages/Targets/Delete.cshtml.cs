using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using APIHotProducts.Data;
using APIHotProducts.Models;

namespace APIHotProducts.Pages.Targets
{
#pragma warning disable CS8618
#pragma warning disable CS8601
#pragma warning disable CS8602
#pragma warning disable CS8604
    public class DeleteModel : PageModel
    {
        private readonly APIHotProducts.Data.APIHotProductsContext _context;

        public DeleteModel(APIHotProducts.Data.APIHotProductsContext context)
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

            var target = await _context.Target.FirstOrDefaultAsync(m => m.ID == id);

            if (target == null)
            {
                return NotFound();
            }
            else 
            {
                Target = target;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Target == null)
            {
                return NotFound();
            }
            var target = await _context.Target.FindAsync(id);

            if (target != null)
            {
                Target = target;
                _context.Target.Remove(Target);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
#pragma warning restore CS8618
#pragma warning restore CS8601
#pragma warning restore CS8602
#pragma warning restore CS8604
}
