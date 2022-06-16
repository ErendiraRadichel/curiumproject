using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using APIHotProducts.Data;
using APIHotProducts.Models;

namespace APIHotProducts.Pages.Targets
{
#pragma warning disable CS8618
#pragma warning disable CS8602
    public class CreateModel : PageModel
    {
        private readonly APIHotProducts.Data.APIHotProductsContext _context;

        public CreateModel(APIHotProducts.Data.APIHotProductsContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Target Target { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Target == null || Target == null)
            {
                return Page();
            }

            _context.Target.Add(Target);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
#pragma warning restore CS8618
#pragma warning restore CS8602
}
