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

namespace TargetDataBase.Pages.IBAs
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
      public IBA IBA { get; set; }
      public string ErrorMessage { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id, bool? saveChangesError = false)
        {
            if (id == null || _context.IBAs == null)
            {
                return NotFound();
            }

            IBA = await _context.IBAs
                .Include(s => s.IBATests)
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.ID == id);
            
            //var iba = await _context.IBAs.FirstOrDefaultAsync(m => m.ID == id);

            if (IBA == null)
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
            if (id == null || _context.IBAs == null)
            {
                return NotFound();
            }
            var iba = await _context.IBAs.FindAsync(id);

            if (iba == null)
            {
                return NotFound();
            }
            try
            {
                _context.IBAs.Remove(iba);
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
