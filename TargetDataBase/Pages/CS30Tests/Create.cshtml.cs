using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using TargetDataBase.Data;
using TargetDataBase.Models;

namespace TargetDataBase.Pages.CS30Tests
{
    public class CreateModel : PageModel
    {
        private readonly TargetDataBase.Data.TargetDataBaseContext _context;

        public CreateModel(TargetDataBase.Data.TargetDataBaseContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["CS30ID"] = new SelectList(_context.CS30s, "ID", "ID");
            return Page();
        }

        [BindProperty]
        public CS30Test CS30Test { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.CS30Tests.Add(CS30Test);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
