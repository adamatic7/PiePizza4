using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PiePizza4.Models;

namespace PiePizza4.Pages.Pies
{
    public class DetailsModel : PageModel
    {
        private readonly PiePizza4.Models.PiePizzariaContext _context;

        public DetailsModel(PiePizza4.Models.PiePizzariaContext context)
        {
            _context = context;
        }

        public Pie Pie { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Pie = await _context.Pie.FirstOrDefaultAsync(m => m.Id == id);

            if (Pie == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
