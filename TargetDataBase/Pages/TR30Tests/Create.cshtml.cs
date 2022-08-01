using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using TargetDataBase.Data;
using TargetDataBase.Models;

namespace TargetDataBase.Pages.TR30Tests
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
        ViewData["TR30ID"] = new SelectList(_context.TR30s, "ID", "ID");
            return Page();
        }

        [BindProperty]
        public TR30Test TR30Test { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.TR30Tests.Add(TR30Test);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
