using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CozySmart.Models
{
    public class SearchAccommodation
    {


       // public int Id { get; set; }

        //public ApplicationUser ApplicationUser { get; set; }

      //  public int ApplicationUserId { get; set; }

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

        public string Location { get; set; }

    }
}