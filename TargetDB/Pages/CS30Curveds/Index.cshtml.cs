using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TargetDB.Data;
using TargetDB.Models;

namespace TargetDB.Pages.CS30Curveds
{
    public class IndexModel : PageModel
    {
        private readonly TargetDB.Data.TargetContext _context;

        public IndexModel(TargetDB.Data.TargetContext context)
        {
            _context = context;
        }

        public IList<CS30Curved> CS30Curved { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.CS30Curveds != null)
            {
                CS30Curved = await _context.CS30Curveds.ToListAsync();
            }
        }
    }
}
