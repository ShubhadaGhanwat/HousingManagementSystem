using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HousingManagementSystem.Application.Dtos
{
    public class CommiteeUpdateDto
    {
        public int CommiteeId { get; set; }

        [Required]
        public string Position { get; set; } = null!;

        public string? Description { get; set; }
    }
}
