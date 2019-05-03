using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CozySmart.Models
{
    public class elements
    {

        public int Accommodation_Id { get; set; }

        public string Accommodation_title { get; set; }

        public string Accommodation_Adress { get; set; }
        public string Accommodation_Description { get; set; }
        public int Accommodation_Rooms { get; set; }
        public int Accommodation_Baths { get; set; }
        public int Accommodation_Price { get; set; }
        public int Accommodation_Occupancy { get; set; }
        public string Accommodation_Location { get; set; }
        [Display(Name = "Arrival Date")]
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]

        public DateTime Arrival { get; set; }


        [Display(Name = "Departure Date")]
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]

        public DateTime Departure { get; set; }


    }
}