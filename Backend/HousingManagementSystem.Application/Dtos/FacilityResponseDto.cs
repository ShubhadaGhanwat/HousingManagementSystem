using System;
using System.Collections.Generic;
using System.Text;

namespace HousingManagementSystem.Application.Dtos
{
    public class FacilityResponseDto
    {
        public int FacilityId { get; set; }

        public string FacilityName { get; set; } = null!;

        public string Description { get; set; } = null!;

        public int? Flag { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public DateTime? DeletedAt { get; set; }

        public DateTime? RestoredAt { get; set; }
    }
}
