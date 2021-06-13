using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TourTravel.Model
{
    public class Salary
    {

        public int Id { get; set; }

        [Display(Name = "Name ")]
        public string Name { get; set; }

        [Display(Name = "Payment ")]
        public int Payment { get; set; }


        [Display(Name = "Date")]
        public DateTime PaymentDate { get; set; }


        public Helper StaffId { get; set; }

    }
}
