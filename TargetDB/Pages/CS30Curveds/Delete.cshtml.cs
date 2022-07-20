using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using TargetDB.Data;
using TargetDB.Models;

namespace TargetDB.Pages.CS30Curveds
{
    public class DeleteModel : PageModel
    {
        private readonly TargetDB.Data.TargetContext _context;
        private readonly ILogger<DeleteModel> _logger;

        public DeleteModel(TargetDB.Data.TargetContext context, ILogger<DeleteModel> logger)
        {
            _context = context;
            _logger = logger;
        }

        [BindProperty]
      public CS30Curved CS30Curved { get; set; }
      public string ErrorMessage { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id, bool? saveChangesError = false)
        {
            if (id == null || _context.CS30Curveds == null)
            {
                return NotFound();
            }

            CS30Curved = await _context.CS30Curveds
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.ID == id);

            //var cs30curved = await _context.CS30Curveds.FirstOrDefaultAsync(m => m.ID == id);

            if (CS30Curved == null)
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
            if (id == null || _context.CS30Curveds == null)
            {
                return NotFound();
            }
            
            var cs30curved = await _context.CS30Curveds.FindAsync(id);

            if (CS30Curved == null)
            {
                return NotFound();
            }
            try
            {
                _context.CS30Curveds.Remove(cs30curved);
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
