using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HousingManagementSystem.Application.Dtos
{
    public class CommiteeMemberUpdateDto
    {
        [Required]
        public int CommiteeMemberId { get; set; }

        [Required]
        public int CommiteeId { get; set; }

        [Required]
        public string Id { get; set; } = null!;

        [Required]
        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public string? WorkingPeriod { get; set; }

        public string? HightligtedWork { get; set; }
    }
}
