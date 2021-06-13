using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TourTravel.Data;
using TourTravel.Model;

namespace TourTravel.Pages.TourPackage
{
    public class IndexModel : PageModel
    {
        private readonly TourTravel.Data.TourTravelContext _context;

        public IndexModel(TourTravel.Data.TourTravelContext context)
        {
            _context = context;
        }

        public IList<Package> Package { get;set; }

        public async Task OnGetAsync()
        {
            Package = await _context.Package.ToListAsync();
        }
    }
}
