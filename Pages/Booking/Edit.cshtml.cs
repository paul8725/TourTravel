using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TourTravel.Data;
using TourTravel.Model;

namespace TourTravel.Pages.Booking
{
    public class EditModel : PageModel
    {
        private readonly TourTravel.Data.TourTravelContext _context;

        public EditModel(TourTravel.Data.TourTravelContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(PackageBooking).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PackageBookingExists(PackageBooking.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool PackageBookingExists(int id)
        {
            return _context.PackageBooking.Any(e => e.Id == id);
        }
    }
}
