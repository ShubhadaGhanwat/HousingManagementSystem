using System;
using System.Collections.Generic;

namespace HousingManagementSystem.Domain.Models;

public partial class Visitor
{
    public int VistorId { get; set; }

    public int FlatId { get; set; }

    public string? FullName { get; set; }

    public string? PhoneNumber { get; set; }

    public string? VehicleNumber { get; set; }

    public string? VistorType { get; set; }

    public string? Purpose { get; set; }

    public DateTime? EntryTime { get; set; }

    public DateTime? ExitTime { get; set; }

    public string? Remarks { get; set; }

    public int? Flag { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public DateTime? RestoredAt { get; set; }

    public virtual Flat Flat { get; set; } = null!;
}
