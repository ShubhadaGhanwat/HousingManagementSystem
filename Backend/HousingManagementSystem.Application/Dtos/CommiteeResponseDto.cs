using System;
using System.Collections.Generic;
using System.Text;

namespace HousingManagementSystem.Application.Dtos
{
    public class CommiteeResponseDto
    {
        public int CommiteeId { get; set; }

        public string Position { get; set; } = null!;

        public string? Description { get; set; }

        public int Flag { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public DateTime? DeletedAt { get; set; }

        public DateTime? RestoredAt { get; set; }
    }
}
