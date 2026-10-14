using System;
using System.Collections.Generic;
using System.Text;

namespace HousingManagementSystem.Application.Dtos
{
    public class FlatResponseDto
    {
        public int FlatId { get; set; }

        public int WingId { get; set; }

        public string FlatNumber { get; set; } = null!;

        public int FloorNumber { get; set; }

        public string FlatType { get; set; }

        public string AreaSqft { get; set; }

        public int? Flag { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public DateTime? DeletedAt { get; set; }

        public DateTime? RestoredAt { get; set; }
    }
}
