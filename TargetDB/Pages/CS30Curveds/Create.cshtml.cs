using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using TargetDB.Data;
using TargetDB.Models;

namespace TargetDB.Pages.CS30Curveds
{
    public class CreateModel : PageModel
    {
        private readonly TargetDB.Data.TargetContext _context;

        public CreateModel(TargetDB.Data.TargetContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public CS30Curved CS30Curved { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.CS30Curveds.Add(CS30Curved);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
