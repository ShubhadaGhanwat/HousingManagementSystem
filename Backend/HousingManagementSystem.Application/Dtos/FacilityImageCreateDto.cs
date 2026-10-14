using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HousingManagementSystem.Application.Dtos
{
    public class FacilityImageCreateDto
    {
        [Required]
        public int FacilityId { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string FacilityImage { get; set; }

        [Required]
        public int DisplayOrder { get; set; }
    }
}
