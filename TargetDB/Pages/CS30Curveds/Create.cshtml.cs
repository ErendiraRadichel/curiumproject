using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using TargetDB.Data;
using TargetDB.Models;

namespace TargetDB.Pages.CS30Curveds
{
    public class CreateModel : PageModel
    {
        private readonly TargetDB.Data.TargetContext _context;

        public CreateModel(TargetDB.Data.TargetContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public CS30Curved CS30Curved { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            var emptyCS30 = new CS30Curved();

            if (await TryUpdateModelAsync<CS30Curved>(
                emptyCS30,
                "cs30curved",   // Prefix for form value.
                s => s.Status, s => s.WarehouseDate, s => s.WarehouseName, s => s.WarehouseCode, s => s.WarehouseLotNum, s => s.CyclotronDate, s => s.CyclotronName, s => s.Quantity,
                s => s.PlatingDate, s => s.PlatingName, s => s.PlatingCode, s => s.PlatingLotNum, s => s.ProductName, s => s.TargetNum, s => s.BombardingDate, s => s.BombardingName,
                s => s.ProcessingDate, s => s.ProcessingName, s => s.ProcessingLotNum))
            {
                _context.CS30Curveds.Add(emptyCS30);
                await _context.SaveChangesAsync();
                return RedirectToPage("./Index");
            }
            return Page();
        }
    }
}
