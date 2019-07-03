using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PiePizza4.Models;

namespace PiePizza4.Pages
{
    public class IndexModel : PageModel
    {
        private readonly PiePizza4.Models.PiePizzariaContext _context;

        public IndexModel(PiePizza4.Models.PiePizzariaContext context)
        {
            _context = context;
        }

        public IList<Pie> Pie { get; set; }

        public async Task OnGetAsync()
        {
            Pie = await _context.Pie.ToListAsync();
        }
    }
}
