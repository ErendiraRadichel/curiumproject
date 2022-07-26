using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TargetDataBase.Data;
using TargetDataBase.Models;

namespace TargetDataBase.Pages.IBATests
{
    public class DeleteModel : PageModel
    {
        private readonly TargetDataBase.Data.TargetDataBaseContext _context;

        public DeleteModel(TargetDataBase.Data.TargetDataBaseContext context)
        {
            _context = context;
        }

        [BindProperty]
      public IBATest IBATest { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.IBATests == null)
            {
                return NotFound();
            }

            var ibatest = await _context.IBATests.FirstOrDefaultAsync(m => m.ID == id);

            if (ibatest == null)
            {
                return NotFound();
            }
            else 
            {
                IBATest = ibatest;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.IBATests == null)
            {
                return NotFound();
            }
            var ibatest = await _context.IBATests.FindAsync(id);

            if (ibatest != null)
            {
                IBATest = ibatest;
                _context.IBATests.Remove(IBATest);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
