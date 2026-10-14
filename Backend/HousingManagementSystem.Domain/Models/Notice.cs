using System;
using System.Collections.Generic;

namespace HousingManagementSystem.Domain.Models;

public partial class Notice
{
    public int NoticeId { get; set; }

    public string Title { get; set; } = null!;

    public string Description { get; set; } = null!;

    public DateTime PublishDate { get; set; }

    public DateTime? ExpiryDate { get; set; }

    public string? Attachement { get; set; }

    public string? FeaturedImage { get; set; }

    public int? Flag { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public DateTime? RestoredAt { get; set; }
}
