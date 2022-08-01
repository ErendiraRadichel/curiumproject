using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TargetDataBase.Data;
using TargetDataBase.Models;

namespace TargetDataBase.Pages.TR30Tests
{
    public class DeleteModel : PageModel
    {
        private readonly TargetDataBase.Data.TargetDataBaseContext _context;

        public DeleteModel(TargetDataBase.Data.TargetDataBaseContext context)
        {
            _context = context;
        }

        [BindProperty]
      public TR30Test TR30Test { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.TR30Tests == null)
            {
                return NotFound();
            }

            var tr30test = await _context.TR30Tests.FirstOrDefaultAsync(m => m.ID == id);

            if (tr30test == null)
            {
                return NotFound();
            }
            else 
            {
                TR30Test = tr30test;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.TR30Tests == null)
            {
                return NotFound();
            }
            var tr30test = await _context.TR30Tests.FindAsync(id);

            if (tr30test != null)
            {
                TR30Test = tr30test;
                _context.TR30Tests.Remove(TR30Test);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
