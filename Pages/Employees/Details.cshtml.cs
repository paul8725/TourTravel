using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TourTravel.Data;
using TourTravel.Model;

namespace TourTravel.Pages.Employees
{
    public class DetailsModel : PageModel
    {
        private readonly TourTravel.Data.TourTravelContext _context;

        public DetailsModel(TourTravel.Data.TourTravelContext context)
        {
            _context = context;
        }

        public Helper Helper { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Helper = await _context.Helper.FirstOrDefaultAsync(m => m.Id == id);

            if (Helper == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
