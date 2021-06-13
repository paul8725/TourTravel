using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TourTravel.Data;
using TourTravel.Model;

namespace TourTravel.Pages.Payment
{
    public class DeleteModel : PageModel
    {
        private readonly TourTravel.Data.TourTravelContext _context;

        public DeleteModel(TourTravel.Data.TourTravelContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Salary Salary { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Salary = await _context.Salary.FirstOrDefaultAsync(m => m.Id == id);

            if (Salary == null)
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

            Salary = await _context.Salary.FindAsync(id);

            if (Salary != null)
            {
                _context.Salary.Remove(Salary);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
