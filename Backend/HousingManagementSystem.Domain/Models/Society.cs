using System;
using System.Collections.Generic;

namespace HousingManagementSystem.Domain.Models;

public partial class Society
{
    public int SocietyId { get; set; }

    public string SocietyName { get; set; } = null!;

    public DateTime? EstablishedDate { get; set; }

    public string? DevelopedBy { get; set; }

    public string Address { get; set; } = null!;

    public string City { get; set; } = null!;

    public string State { get; set; } = null!;

    public string? Pincode { get; set; }

    public string Phone { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string? Logo { get; set; }

    public string? Description { get; set; }

    public int? Flag { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public DateTime? RestoredAt { get; set; }
}
