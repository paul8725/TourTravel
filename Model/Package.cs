using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TourTravel.Model
{
    public class Package
    {


        public int Id { get; set; }

        [Display(Name = "Name ")]
        public string Name { get; set; }

        [Display(Name = "Duration")]
        public string Duration { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }



        [Display(Name = "Payment")]
        public int Payment { get; set; }




        [Display(Name = "Post")]
        public string Post { get; set; }
    }
}
