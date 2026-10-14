using System;
using System.Collections.Generic;

namespace HousingManagementSystem.Domain.Models;

public partial class Facility
{
    public int FacilityId { get; set; }

    public string FacilityName { get; set; } = null!;

    public string? Description { get; set; }

    public int? Flag { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public DateTime? RestoredAt { get; set; }

    public virtual ICollection<FacilityImage> FacilityImages { get; set; } = new List<FacilityImage>();
}
