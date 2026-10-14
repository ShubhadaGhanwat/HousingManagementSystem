using System;
using System.Collections.Generic;

namespace HousingManagementSystem.Domain.Models;

public partial class Event
{
    public int EventId { get; set; }

    public string? EventTitle { get; set; }

    public string? Description { get; set; }

    public DateTime? EventDate { get; set; }

    public DateTime? StartTime { get; set; }

    public DateTime? EndTime { get; set; }

    public string? Location { get; set; }

    public int? Flag { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public DateTime? RestoredAt { get; set; }

    public virtual ICollection<EventImage> EventImages { get; set; } = new List<EventImage>();
}
