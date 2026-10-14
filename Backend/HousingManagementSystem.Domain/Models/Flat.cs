using System;
using System.Collections.Generic;

namespace HousingManagementSystem.Domain.Models;

public partial class Flat
{
    public int FlatId { get; set; }

    public int WingId { get; set; }

    public string FlatNumber { get; set; } = null!;

    public int FloorNumber { get; set; }

    public string? FlatType { get; set; }

    public string? AreaSqft { get; set; }

    public int? Flag { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public DateTime? RestoredAt { get; set; }

    public virtual ICollection<MaintainanceBill> MaintainanceBills { get; set; } = new List<MaintainanceBill>();

    public virtual ICollection<Resident> Residents { get; set; } = new List<Resident>();

    public virtual ICollection<Visitor> Visitors { get; set; } = new List<Visitor>();

    public virtual Wing Wing { get; set; } = null!;
}
