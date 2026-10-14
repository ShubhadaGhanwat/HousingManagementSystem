using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HousingManagementSystem.Application.Dtos
{
    public class FlatUpdateDto
    {
       
        public int FlatId { get; set; }

        [Required]
        public int WingId { get; set; }

        [Required]
        public string FlatNumber { get; set; } = null!;

        [Required]
        public int FloorNumber { get; set; }
        
        [Required]
        public string FlatType { get; set; }

        [Required]
        public string AreaSqft { get; set; }
    }
}
