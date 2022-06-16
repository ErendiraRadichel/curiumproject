using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using APIHotProducts.Data;
using APIHotProducts.Models;

namespace APIHotProducts.Pages.Targets
{
    public class DetailsModel : PageModel
    {
        private readonly APIHotProducts.Data.APIHotProductsContext _context;

        public DetailsModel(APIHotProducts.Data.APIHotProductsContext context)
        {
            _context = context;
        }

      public Target Target { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Target == null)
            {
                return NotFound();
            }

            var target = await _context.Target.FirstOrDefaultAsync(m => m.ID == id);
            if (target == null)
            {
                return NotFound();
            }
            else 
            {
                Target = target;
            }
            return Page();
        }
    }
}
