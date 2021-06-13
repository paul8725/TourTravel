using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TourTravel.Model;

namespace TourTravel.Data
{
    public class TourTravelContext : DbContext
    {
        public TourTravelContext (DbContextOptions<TourTravelContext> options)
            : base(options)
        {
        }

        public DbSet<TourTravel.Model.Helper> Helper { get; set; }

        public DbSet<TourTravel.Model.Salary> Salary { get; set; }

        public DbSet<TourTravel.Model.Package> Package { get; set; }

        public DbSet<TourTravel.Model.PackageBooking> PackageBooking { get; set; }

        
    }
}
