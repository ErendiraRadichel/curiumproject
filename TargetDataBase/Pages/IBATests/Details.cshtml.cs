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
    public class DetailsModel : PageModel
    {
        private readonly TargetDataBase.Data.TargetDataBaseContext _context;

        public DetailsModel(TargetDataBase.Data.TargetDataBaseContext context)
        {
            _context = context;
        }

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
    }
}
