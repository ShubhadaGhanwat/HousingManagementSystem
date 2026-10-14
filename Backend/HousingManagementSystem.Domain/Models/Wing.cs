using System;
using System.Collections.Generic;

namespace HousingManagementSystem.Domain.Models;

public partial class Wing
{
    public int WingId { get; set; }

    public string WingName { get; set; } = null!;

    public string WingCode { get; set; } = null!;

    public int NumberOfFloors { get; set; }

    public int? Flag { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public DateTime? RestoredAt { get; set; }

    public virtual ICollection<Flat> Flats { get; set; } = new List<Flat>();

    public virtual ICollection<MaintainanceBill> MaintainanceBills { get; set; } = new List<MaintainanceBill>();

    public virtual ICollection<Resident> Residents { get; set; } = new List<Resident>();
}
