using System;
using System.Collections.Generic;

namespace HousingManagementSystem.Domain.Models;

public partial class Complaint
{
    public int ComplaintId { get; set; }

    public int ComplaintCategoryId { get; set; }

    public string Id { get; set; } = null!;

    public string? Title { get; set; }

    public string? Description { get; set; }

    public string? Priority { get; set; }

    public string? ComplaintStatus { get; set; }

    public string? Remarks { get; set; }

    public int Flag { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public DateTime? RestoredAt { get; set; }

    public virtual ComplaintCategory ComplaintCategory { get; set; } = null!;
}
