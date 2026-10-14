using System;
using System.Collections.Generic;
using System.Text;

namespace HousingManagementSystem.Application.Dtos
{
    public class VisitorResponseDto
    {
        public int VistorId { get; set; }

        public int FlatId { get; set; }

        public string FullName { get; set; } = null!;

        public string PhoneNumber { get; set; } = null!;

        public string VehicleNumber { get; set; } = null!;

        public string VistorType { get; set; } = null!;

        public string Purpose { get; set; } = null!;

        public DateTime EntryTime { get; set; } = null!;

        public DateTime ExitTime { get; set; } = null!;

        public string? Remarks { get; set; }

        public int? Flag { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public DateTime? DeletedAt { get; set; }

        public DateTime? RestoredAt { get; set; }
    }
}
