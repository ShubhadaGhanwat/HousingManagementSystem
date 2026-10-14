using System;
using System.Collections.Generic;
using System.Text;

namespace HousingManagementSystem.Application.Dtos
{
    public class ResidentResponseDto
    {
        public int ResidentId { get; set; } = null!;

        public string FullName { get; set; } = null!;

        public string PhoneNumber { get; set; } = null!;

        public string EmailAddress { get; set; } = null!;

        public int NumberOfMembers { get; set; }

        public string ProfilePhoto { get; set; }

        public int FlatId { get; set; }

        public int WingId { get; set; }

        public string? ResidentType { get; set; }

        public DateTime MoveInDate { get; set; }

        public DateTime? MoveOutDate { get; set; }

        public bool? IsPrimaryResident { get; set; }

        public string Gender { get; set; }

        public DateOnly? BirthDate { get; set; }

        public string? Age { get; set; }

        public string Id { get; set; } = null!;
    }
}
