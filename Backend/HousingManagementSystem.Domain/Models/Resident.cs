using System;
using System.Collections.Generic;

namespace HousingManagementSystem.Domain.Models;

public partial class Resident
{
    public int ResidentId { get; set; }

    public string FullName { get; set; } = null!;

    public string PhoneNumber { get; set; } = null!;

    public string EmailAddress { get; set; } = null!;

    public int NumberOfMembers { get; set; }

    public string? ProfilePhoto { get; set; }

    public int FlatId { get; set; }

    public int WingId { get; set; }

    public string? ResidentType { get; set; }

    public DateTime MoveInDate { get; set; }

    public DateTime? MoveOutDate { get; set; }

    public bool IsPrimaryResident { get; set; }

    public int? Flag { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public DateTime? RestoredAt { get; set; }

    public string? Gender { get; set; }

    public DateOnly? BirthDate { get; set; }

    public string? Age { get; set; }

    public string Id { get; set; } = null!;

    public virtual Flat Flat { get; set; } = null!;

    public virtual Wing Wing { get; set; } = null!;
}
