using System;
using System.Collections.Generic;
using System.Text;

namespace HousingManagementSystem.Application.Dtos
{
    public class MaintainanceBillResponseDto
    {
        public int MaintainanceId { get; set; }

        public string Id { get; set; } = null!;

        public int FlatId { get; set; } = null!;

        public int WingId { get; set; } = null!;

        public DateOnly BillDate { get; set; } = null!;

        public DateTime GeneratedAt { get; set; } = null!;

        public decimal WaterCharges { get; set; } = null!;

        public decimal ParkingCharges { get; set; } = null!;

        public decimal OtherCharges { get; set; } = null!;

        public DateOnly Duedate { get; set; } = null!;

        public decimal MaintainanceAmount { get; set; } = null!;

        public decimal PaidAmount { get; set; } = null!;

        public decimal? UnpaidAmount { get; set; }

        public decimal? TotalAmount { get; set; }

        public string? Discount { get; set; }

        public decimal? Penalty { get; set; }

        public string PayementStatus { get; set; } = null!;

        public string PaymentMode { get; set; } = null!;

        public DateTime PayementDate { get; set; } = null!;

        public string? TransactionReference { get; set; }

        public int Flag { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public DateTime? DeletedAt { get; set; }

        public DateTime? RestoredAt { get; set; }
    }
}
