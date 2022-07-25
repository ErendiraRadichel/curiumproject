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
    public class DetailsModel : PageModel
    {
        private readonly TargetDataBase.Data.TargetDataBaseContext _context;

        public DetailsModel(TargetDataBase.Data.TargetDataBaseContext context)
        {
            _context = context;
        }

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
    }
}
