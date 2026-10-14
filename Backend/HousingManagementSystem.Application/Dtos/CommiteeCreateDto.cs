using System;
using HousingManagementSystem.Domain.Models;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace HousingManagementSystem.Application.Dtos
{
    public class CommiteeCreateDto
    {
        [Required]
        public string Position { get; set; } = null!;

        public string? Description { get; set; }

    }
}
