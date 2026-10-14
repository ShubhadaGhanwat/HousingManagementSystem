using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HousingManagementSystem.Application.Dtos
{
    public class EventImageUpdateDto
    {
        [Required]
        public int EventImageId { get; set; }

        [Required]
        public int EventId { get; set; }

        [Required]
        public string ImagePath { get; set; } = null!;

        public string? ImageTitle { get; set; }

        [Required]
        public int DisplayOrder { get; set; }
    }
}
