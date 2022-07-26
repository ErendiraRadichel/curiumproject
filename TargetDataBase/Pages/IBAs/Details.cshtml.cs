using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TargetDataBase.Data;
using TargetDataBase.Models;

namespace TargetDataBase.Pages.IBAs
{
    public class DetailsModel : PageModel
    {
        private readonly TargetDataBase.Data.TargetDataBaseContext _context;

        public DetailsModel(TargetDataBase.Data.TargetDataBaseContext context)
        {
            _context = context;
        }

      public IBA IBA { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.IBAs == null)
            {
                return NotFound();
            }

            IBA = await _context.IBAs
                .Include(s => s.IBATests)
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.ID == id);

            if (IBA == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
