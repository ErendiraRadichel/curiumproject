using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using TargetDataBase.Data;
using TargetDataBase.Models;

namespace TargetDataBase.Pages.TR30s
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
        public TR30 TR30 { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            var emptyTR30 = new TR30();

            if (await TryUpdateModelAsync<TR30>(
                emptyTR30,
                "tr30",   // Prefix for form value.
                s => s.Status, s => s.WarehouseDate, s => s.WarehouseName, s => s.WFaceCode, s => s.WBodyCode, s => s.WFaceLotNum, s => s.WBodyLotNum, s => s.CyclotronDate, s => s.CyclotronName,
                s => s.CFaceCode, s => s.CBodyCode, s => s.Quantity, s => s.PlatingDate, s => s.PlatingName, s => s.PlatingCode, s => s.PlatingLotNum, s => s.ProductName, s => s.TargetNum, s => s.BombardingDate,
                s => s.BombardingName, s => s.ProcessingDate, s => s.ProcessingName, s => s.ProcessingLotNum))
            {
                _context.TR30s.Add(emptyTR30);
                await _context.SaveChangesAsync();
                return RedirectToPage("./Index");
            }
            return Page();
        }
    }
}
