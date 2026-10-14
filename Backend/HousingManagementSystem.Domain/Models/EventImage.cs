using System;
using System.Collections.Generic;

namespace HousingManagementSystem.Domain.Models;

public partial class EventImage
{
    public int EventImageId { get; set; }

    public int EventId { get; set; }

    public string ImagePath { get; set; } = null!;

    public string? ImageTitle { get; set; }

    public int DisplayOrder { get; set; }

    public int? Flag { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public DateTime? RestoredAt { get; set; }

    public virtual Event Event { get; set; } = null!;
}
