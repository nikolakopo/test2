using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using CozySmart.Models;

namespace CozySmart.Models
{
    public class Elementsforbooking 
    {
        public int Id { get; set; }
        public int Accommodation_Id { get; set; }

        public string Accommodation_title { get; set; }


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