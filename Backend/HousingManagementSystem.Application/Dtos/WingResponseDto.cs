using System;
using System.Collections.Generic;
using System.Text;

namespace HousingManagementSystem.Application.Dtos
{
    public class WingResponseDto
    {
        public int WingId { get; set; }

        public string WingName { get; set; } = null!;

        public string WingCode { get; set; } = null!;

        public int NumberOfFloors { get; set; } = null!;

        public int? Flag { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public DateTime? DeletedAt { get; set; }

        public DateTime? RestoredAt { get; set; }
    }
}
