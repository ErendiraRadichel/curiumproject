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
    public class DetailsModel : PageModel
    {
        private readonly TargetDataBase.Data.TargetDataBaseContext _context;

        public DetailsModel(TargetDataBase.Data.TargetDataBaseContext context)
        {
            _context = context;
        }

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
    }
}
