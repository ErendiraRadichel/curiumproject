using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TargetDB.Data;
using TargetDB.Models;

namespace TargetDB.Pages.CS30Curveds
{
    public class EditModel : PageModel
    {
        private readonly TargetDB.Data.TargetContext _context;

        public EditModel(TargetDB.Data.TargetContext context)
        {
            _context = context;
        }

        [BindProperty]
        public CS30Curved CS30Curved { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.CS30Curveds == null)
            {
                return NotFound();
            }

            CS30Curved = await _context.CS30Curveds.FindAsync(id);

            if (CS30Curved == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync(int id)
        {
            var cs30ToUpdate = await _context.CS30Curveds.FindAsync(id);

            if (cs30ToUpdate == null)
            {
                return NotFound();
            }

            if (await TryUpdateModelAsync<CS30Curved>(
                cs30ToUpdate,
                "cs30curved",
                s => s.Status, s => s.WarehouseDate, s => s.WarehouseName, s => s.WarehouseCode, s => s.WarehouseLotNum, s => s.CyclotronDate, s => s.CyclotronName, s => s.Quantity,
                s => s.PlatingDate, s => s.PlatingName, s => s.PlatingCode, s => s.PlatingLotNum, s => s.ProductName, s => s.TargetNum, s => s.BombardingDate, s => s.BombardingName,
                s => s.ProcessingDate, s => s.ProcessingName, s => s.ProcessingLotNum))
            {
                await _context.SaveChangesAsync();
                return RedirectToPage("./Index");
            }
            return Page();
        }

        private bool CS30CurvedExists(int id)
        {
          return _context.CS30Curveds.Any(e => e.ID == id);
        }
    }
}
