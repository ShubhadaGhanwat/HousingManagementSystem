using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HousingManagementSystem.Application.Dtos
{
    public class ComplaintCreateDto
    {
        [Required]
        public int ComplaintCategoryId { get; set; }

        [Required]
        public string Id { get; set; } = null!;

        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string Priority { get; set; }

        public string? ComplaintStatus { get; set; }

        public string? Remarks { get; set; }
    }
}
