using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TargetDataBase.Data;
using TargetDataBase.Models;

namespace TargetDataBase.Pages.CS30Tests
{
    public class DeleteModel : PageModel
    {
        private readonly TargetDataBase.Data.TargetDataBaseContext _context;

        public DeleteModel(TargetDataBase.Data.TargetDataBaseContext context)
        {
            _context = context;
        }

        [BindProperty]
      public CS30Test CS30Test { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.CS30Tests == null)
            {
                return NotFound();
            }

            var cs30test = await _context.CS30Tests.FirstOrDefaultAsync(m => m.ID == id);

            if (cs30test == null)
            {
                return NotFound();
            }
            else 
            {
                CS30Test = cs30test;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.CS30Tests == null)
            {
                return NotFound();
            }
            var cs30test = await _context.CS30Tests.FindAsync(id);

            if (cs30test != null)
            {
                CS30Test = cs30test;
                _context.CS30Tests.Remove(CS30Test);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
