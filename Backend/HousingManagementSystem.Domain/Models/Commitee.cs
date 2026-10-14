using System;
using System.Collections.Generic;

namespace HousingManagementSystem.Domain.Models;

public partial class Commitee
{
    public int CommiteeId { get; set; }

    public string Position { get; set; } = null!;

    public string? Description { get; set; }

    public int Flag { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public DateTime? RestoredAt { get; set; }

    public virtual ICollection<CommiteeMember> CommiteeMembers { get; set; } = new List<CommiteeMember>();
}
