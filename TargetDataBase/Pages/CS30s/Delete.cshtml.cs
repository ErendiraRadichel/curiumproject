using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using TargetDataBase.Data;
using TargetDataBase.Models;

namespace TargetDataBase.Pages.CS30s
{
    public class DeleteModel : PageModel
    {
        private readonly TargetDataBase.Data.TargetDataBaseContext _context;
        private readonly ILogger<DeleteModel> _logger;

        public DeleteModel(TargetDataBase.Data.TargetDataBaseContext context, ILogger<DeleteModel> logger)
        {
            _context = context;
            _logger = logger;
        }

        [BindProperty]
      public CS30 CS30 { get; set; }
      public string ErrorMessage { get; set; }


        public async Task<IActionResult> OnGetAsync(int? id, bool? saveChangesError = false)
        {
            if (id == null || _context.CS30s == null)
            {
                return NotFound();
            }

            CS30 = await _context.CS30s.AsNoTracking()
                .FirstOrDefaultAsync(m => m.ID == id);

            if (CS30 == null)
            {
                return NotFound();
            }
            if (saveChangesError.GetValueOrDefault())
            {
                ErrorMessage = String.Format("Delete {ID} failed. Try again", id);
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.CS30s == null)
            {
                return NotFound();
            }

            var cs30 = await _context.CS30s.FindAsync(id);

            if (cs30 == null)
            {
                return NotFound();
            }
            try
            {
                _context.CS30s.Remove(cs30);
                await _context.SaveChangesAsync();
                return RedirectToPage("./Index");
            }
            catch (DbUpdateException ex)
            {
                _logger.LogError(ex, ErrorMessage);

                return RedirectToAction("./Delete",
                                     new { id, saveChangesError = true });
            }
        }
    }
}
