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
    public class DeleteModel : PageModel
    {
        private readonly PiePizza4.Models.PiePizzariaContext _context;

        public DeleteModel(PiePizza4.Models.PiePizzariaContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Pie = await _context.Pie.FindAsync(id);

            if (Pie != null)
            {
                _context.Pie.Remove(Pie);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
