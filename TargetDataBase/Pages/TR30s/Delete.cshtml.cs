using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TargetDataBase.Data;
using TargetDataBase.Models;

namespace TargetDataBase.Pages.TR30s
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
      public TR30 TR30 { get; set; }
      public string ErrorMessage { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id, bool? saveChangesError = false)
        {
            if (id == null || _context.TR30s == null)
            {
                return NotFound();
            }

            TR30 = await _context.TR30s
                .Include(s => s.TR30Tests)
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.ID == id);

            //var tr30 = await _context.TR30s.FirstOrDefaultAsync(m => m.ID == id);

            if (TR30 == null)
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
            if (id == null || _context.TR30s == null)
            {
                return NotFound();
            }
            var tr30 = await _context.TR30s.FindAsync(id);

            if (tr30 == null)
            {
                return NotFound();
            }
            try
            {
                _context.TR30s.Remove(tr30);
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
