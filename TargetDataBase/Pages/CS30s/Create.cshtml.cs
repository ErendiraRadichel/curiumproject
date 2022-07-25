using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using TargetDataBase.Data;
using TargetDataBase.Models;

namespace TargetDataBase.Pages.CS30s
{
    public class CreateModel : PageModel
    {
        private readonly TargetDataBase.Data.TargetDataBaseContext _context;

        public CreateModel(TargetDataBase.Data.TargetDataBaseContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public CS30 CS30 { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            var emptyCS30 = new CS30();

            if (await TryUpdateModelAsync<CS30>(
                emptyCS30,
                "cs30",   // Prefix for form value.
                s => s.Status, s => s.TargetType, s => s.WarehouseDate, s => s.WarehouseName, s => s.WarehouseCode, s => s.WarehouseLotNum, s => s.CyclotronDate, s => s.CyclotronName,
                s => s.CyclotronCode, s => s.Quantity, s => s.PlatingDate, s => s.PlatingName, s => s.PlatingCode, s => s.PlatingLotNum, s => s.ProductName, s => s.TargetNum, s => s.BombardingDate,
                s => s.BombardingName, s => s.ProcessingDate, s => s.ProcessingName, s => s.ProcessingLotNum))
            {
                _context.CS30s.Add(emptyCS30);
                await _context.SaveChangesAsync();
                return RedirectToPage("./Index");
            }
            return Page();
        }
    }
}
