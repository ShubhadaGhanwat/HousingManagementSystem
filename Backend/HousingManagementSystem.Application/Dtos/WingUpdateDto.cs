using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HousingManagementSystem.Application.Dtos
{
    public class WingUpdateDto
    {
        public int WingId { get; set; }

        [Required]
        public string WingName { get; set; } = null!;

        [Required]
        public string WingCode { get; set; } = null!;

        [Required]
        public int NumberOfFloors { get; set; }
    }
}
