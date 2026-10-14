using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HousingManagementSystem.Application.Dtos
{
    public class EventCreateDto
    {
        [Required]
        public string EventTitle { get; set; } = null!;

        [Required]
        public string Description { get; set; } = null!;

        [Required]
        public DateTime EventDate { get; set; } = null!;

        [Required]
        public DateTime StartTime { get; set; } = null!;

        [Required]
        public DateTime EndTime { get; set; } = null!;

        [Required]
        public string Location { get; set; } = null!;
    }
}
