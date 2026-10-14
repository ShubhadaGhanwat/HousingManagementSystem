using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HousingManagementSystem.Application.Dtos
{
    public class FacilityCreateDto
    {
        [Required]
        public string FacilityName { get; set; } = null!;

        [Required]
        public string Description { get; set; } = null!;
    }
}
