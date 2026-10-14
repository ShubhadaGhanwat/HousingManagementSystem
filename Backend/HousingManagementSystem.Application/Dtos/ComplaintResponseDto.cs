using System;
using System.Collections.Generic;
using System.Text;

namespace HousingManagementSystem.Application.Dtos
{
    public class ComplaintResponseDto
    {
        public int ComplaintId { get; set; }

        public int ComplaintCategoryId { get; set; }

        public string Id { get; set; } = null!;

        public string Title { get; set; } = null!;

        public string Description { get; set; } = null!;

        public string Priority { get; set; } = null!;

        public string? ComplaintStatus { get; set; }

        public string? Remarks { get; set; }
    }
}
