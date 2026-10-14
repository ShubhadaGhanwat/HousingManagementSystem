using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HousingManagementSystem.Application.Dtos
{
    public class ResidentUpdateDto
    {
        [Required]
        public int ResidentId { get; set; }

        [Required]
        public string FullName { get; set; } = null!;

        [Required]
        public string PhoneNumber { get; set; } = null!;

        [Required]
        public string EmailAddress { get; set; } = null!;

        [Required]
        public int NumberOfMembers { get; set; }

        [Required]
        public string ProfilePhoto { get; set; }

        [Required]
        public int FlatId { get; set; }

        [Required]
        public int WingId { get; set; }

        public string? ResidentType { get; set; }

        [Required]
        public DateTime MoveInDate { get; set; }

        public DateTime? MoveOutDate { get; set; }

        public bool IsPrimaryResident { get; set; }
        [Required]
        public string Gender { get; set; }

        public DateOnly? BirthDate { get; set; }

        public string? Age { get; set; }

        [Required]
        public string Id { get; set; } = null!;
    }
}
