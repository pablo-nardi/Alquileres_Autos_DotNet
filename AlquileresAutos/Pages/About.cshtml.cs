using AlquileresAutos.Models;
using AlquileresAutos.Data;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.Pages
{
    public class AboutModel : PageModel
    {
        private readonly AlquileresAutosContext _context;

        public AboutModel(AlquileresAutosContext context)
        {
            _context = context;
        }

    }
}