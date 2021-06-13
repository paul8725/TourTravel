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
    public class IndexModel : PageModel
    {
        private readonly TourTravel.Data.TourTravelContext _context;

        public IndexModel(TourTravel.Data.TourTravelContext context)
        {
            _context = context;
        }

        public IList<Salary> Salary { get;set; }

        public async Task OnGetAsync()
        {
            Salary = await _context.Salary.ToListAsync();
        }
    }
}
