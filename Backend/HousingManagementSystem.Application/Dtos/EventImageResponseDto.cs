using System;
using System.Collections.Generic;
using System.Text;

namespace HousingManagementSystem.Application.Dtos
{
    public class EventImageResponseDto
    {
        public int EventImageId { get; set; }

        public int EventId { get; set; }

        public string ImagePath { get; set; } = null!;

        public string? ImageTitle { get; set; }

        public int DisplayOrder { get; set; }

        public int? Flag { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public DateTime? DeletedAt { get; set; }

        public DateTime? RestoredAt { get; set; }
    }
}
