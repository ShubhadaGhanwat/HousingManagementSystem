using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HousingManagementSystem.Application.Dtos
{
    public class VisitorUpdateDto
    {
        [Required]
        public int VistorId { get; set; }

        [Required]
        public int FlatId { get; set; }

        [Required]
        public string FullName { get; set; } = null!;

        [Required]
        public string PhoneNumber { get; set; } = null!;

        [Required]
        public string VehicleNumber { get; set; } = null!;

        [Required]
        public string VistorType { get; set; } = null!;

        [Required]
        public string Purpose { get; set; } = null!;

        [Required]
        public DateTime EntryTime { get; set; } = null!;

        [Required]
        public DateTime ExitTime { get; set; } = null!;

        public string? Remarks { get; set; }

        

    }
}
