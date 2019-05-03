﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CozySmart.Models
{
    public class Image
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "The URL of the image is required")]
        [DataType(DataType.ImageUrl)]
        public string ImageUrl { get; set; }

        public Accommodation Accommodation { get; set; }

        [Display(Name = "Accommodation Name")]
        [Required]
        public int AccommodationId { get; set; }

        
    }
}