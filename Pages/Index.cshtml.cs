using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TourTravel.Model;

namespace TourTravel.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        private readonly TourTravel.Data.TourTravelContext _context;
        public IndexModel(ILogger<IndexModel> logger, TourTravel.Data.TourTravelContext context)
        {
            _logger = logger;

            _context = context;
        }
        public IList<PackageBooking> PackageBooking { get; set; }

        public IList<Package> Package { get; set; }

        public async Task OnGetAsync()
        {
            Package = await _context.Package.ToListAsync();

            PackageBooking = await _context.PackageBooking.ToListAsync();
        }




    }
}
