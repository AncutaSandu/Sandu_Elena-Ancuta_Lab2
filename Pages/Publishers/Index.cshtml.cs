using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Sandu_Elena_Ancuta_Lab2.Data;
using Sandu_Elena_Ancuta_Lab2.Models;

namespace Sandu_Elena_Ancuta_Lab2.Pages.Publishers
{
    public class IndexModel : PageModel
    {
        private readonly Sandu_Elena_Ancuta_Lab2.Data.Sandu_Elena_Ancuta_Lab2Context _context;

        public IndexModel(Sandu_Elena_Ancuta_Lab2.Data.Sandu_Elena_Ancuta_Lab2Context context)
        {
            _context = context;
        }

        public IList<Publisher> Publisher { get;set; } = default!;

        public async Task OnGetAsync()
        {
          Book = await _context.Book
                .Include(b=>b.Publisher)
                .ToListAsync();
            
            
            
            if (_context.Publisher != null)
            {
                Publisher = await _context.Publisher.ToListAsync();
            }
        }
    }
}
