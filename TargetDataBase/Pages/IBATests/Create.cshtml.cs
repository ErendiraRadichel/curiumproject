using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using TargetDataBase.Data;
using TargetDataBase.Models;

namespace TargetDataBase.Pages.IBATests
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
        ViewData["IBAID"] = new SelectList(_context.IBAs, "ID", "ID");
            return Page();
        }

        [BindProperty]
        public IBATest IBATest { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.IBATests.Add(IBATest);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
