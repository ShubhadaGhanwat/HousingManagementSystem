using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HousingManagementSystem.Application.Dtos
{
    public class NoticeCreateDto
    {
        [Required]
        public string Title { get; set; } = null!;

        [Required]
        public string Description { get; set; } = null!;

        [Required]
        public DateTime PublishDate { get; set; }

        public DateTime? ExpiryDate { get; set; }

        public string? Attachement { get; set; }

        public string? FeaturedImage { get; set; }
    }
}
