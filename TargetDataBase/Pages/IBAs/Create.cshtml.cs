using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using TargetDataBase.Data;
using TargetDataBase.Models;

namespace TargetDataBase.Pages.IBAs
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
        public IBA IBA { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            var emptyIBA = new IBA();

            if (await TryUpdateModelAsync<IBA>(
                emptyIBA,
                "iba",   // Prefix for form value.
                s => s.Status, s => s.WarehouseDate, s => s.WarehouseName, s => s.WarehouseCode, s => s.WarehouseLotNum, s => s.CyclotronDate, s => s.CyclotronName,
                s => s.CyclotronCode, s => s.Quantity, s => s.PlatingDate, s => s.PlatingName, s => s.PlatingCode, s => s.PlatingLotNum, s => s.ProductName, s => s.TargetNum, s => s.BombardingDate,
                s => s.BombardingName, s => s.ProcessingDate, s => s.ProcessingName, s => s.ProcessingLotNum))
            {
                _context.IBAs.Add(emptyIBA);
                await _context.SaveChangesAsync();
                return RedirectToPage("./Index");
            }
            return Page();
        }
    }
}
