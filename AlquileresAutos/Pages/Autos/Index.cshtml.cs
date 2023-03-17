using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AlquileresAutos.Data;
using AlquileresAutos.Models;

namespace AlquileresAutos.Pages.Autos
{
    public class IndexModel : PageModel
    {
        private readonly AlquileresAutos.Data.AlquileresAutosContext _context;

        public IndexModel(AlquileresAutos.Data.AlquileresAutosContext context)
        {
            _context = context;
        }

        public IList<Auto> Auto { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Autos != null)
            {
                Auto = await _context.Autos.ToListAsync();
            }
        }
    }
}
