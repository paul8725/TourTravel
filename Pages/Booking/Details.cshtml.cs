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
    public class DetailsModel : PageModel
    {
        private readonly TourTravel.Data.TourTravelContext _context;

        public DetailsModel(TourTravel.Data.TourTravelContext context)
        {
            _context = context;
        }

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
    }
}
