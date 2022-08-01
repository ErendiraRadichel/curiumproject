using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TargetDataBase.Data;
using TargetDataBase.Models;

namespace TargetDataBase.Pages.TR30Tests
{
    public class IndexModel : PageModel
    {
        private readonly TargetDataBase.Data.TargetDataBaseContext _context;

        public IndexModel(TargetDataBase.Data.TargetDataBaseContext context)
        {
            _context = context;
        }

        public IList<TR30Test> TR30Test { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.TR30Tests != null)
            {
                TR30Test = await _context.TR30Tests
                .Include(t => t.TR30).ToListAsync();
            }
        }
    }
}
