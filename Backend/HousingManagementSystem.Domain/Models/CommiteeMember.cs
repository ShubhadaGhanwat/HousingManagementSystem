using System;
using System.Collections.Generic;

namespace HousingManagementSystem.Domain.Models;

public partial class CommiteeMember
{
    public int CommiteeMemberId { get; set; }

    public int CommiteeId { get; set; }

    public string Id { get; set; } = null!;

    public DateTime StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string? WorkingPeriod { get; set; }

    public string? HightligtedWork { get; set; }

    public int Flag { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public DateTime? RestoredAt { get; set; }

    public virtual Commitee Commitee { get; set; } = null!;
}
