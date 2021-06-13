using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TourTravel.Data;
using TourTravel.Model;

namespace TourTravel.Pages.Booking
{
    public class DeleteModel : PageModel
    {
        private readonly TourTravel.Data.TourTravelContext _context;

        public DeleteModel(TourTravel.Data.TourTravelContext context)
        {
            _context = context;
        }

        [BindProperty]
        public PackageBooking PackageBooking { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            PackageBooking = await _context.PackageBooking.FirstOrDefaultAsync(m => m.Id == id);

            if (PackageBooking == null)
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

            PackageBooking = await _context.PackageBooking.FindAsync(id);

            if (PackageBooking != null)
            {
                _context.PackageBooking.Remove(PackageBooking);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
