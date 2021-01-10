using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.Api.Models
{
    public class PointOfInterestForCreationDto
    {
        [Required(ErrorMessage = "Name is required")]
        [MaxLength(50, ErrorMessage= "Max 50 characters")]
        public string Name { get; set; }
        [MaxLength(200)]
        public string Description { get; set; }
    }
}
