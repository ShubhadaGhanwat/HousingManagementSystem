using System;
using System.Collections.Generic;
using System.Text;

namespace HousingManagementSystem.Application.Dtos
{
    public class SocietyResponseDto
    {
        public int SocietyId { get; set; }

        public string SocietyName { get; set; } = null!;

        public DateTime EstablishedDate { get; set; }

        public string DevelopedBy { get; set; }

        public string Address { get; set; } = null!;

        public string City { get; set; } = null!;

        public string State { get; set; } = null!;

        public string? Pincode { get; set; }

        public string Phone { get; set; } = null!;

        public string Email { get; set; } = null!;

        public string? Logo { get; set; }

        public string? Description { get; set; }
    }
}
