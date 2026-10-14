using System;
using System.Collections.Generic;

namespace HousingManagementSystem.Domain.Models;

public partial class MaintainanceBill
{
    public int MaintainanceId { get; set; }

    public string Id { get; set; } = null!;

    public int FlatId { get; set; }

    public int WingId { get; set; }

    public DateOnly? BillDate { get; set; }

    public DateTime? GeneratedAt { get; set; }

    public decimal? WaterCharges { get; set; }

    public decimal? ParkingCharges { get; set; }

    public decimal? OtherCharges { get; set; }

    public DateOnly? Duedate { get; set; }

    public decimal? MaintainanceAmount { get; set; }

    public decimal? PaidAmount { get; set; }

    public decimal? UnpaidAmount { get; set; }

    public decimal? TotalAmount { get; set; }

    public string? Discount { get; set; }

    public decimal? Penalty { get; set; }

    public string? PayementStatus { get; set; }

    public string? PaymentMode { get; set; }

    public DateTime? PayementDate { get; set; }

    public string? TransactionReference { get; set; }

    public int Flag { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public DateTime? RestoredAt { get; set; }

    public virtual Flat Flat { get; set; } = null!;

    public virtual Wing Wing { get; set; } = null!;
}
