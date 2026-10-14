using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HousingManagementSystem.Application.Dtos
{
    public class MaintainanceBillCreateDto
    {
        [Required]
        public string Id { get; set; } = null!;

        [Required]
        public int FlatId { get; set; } = null!;

        [Required]
        public int WingId { get; set; } = null!;

        [Required]
        public DateOnly BillDate { get; set; } = null!;

        [Required]
        public DateTime GeneratedAt { get; set; } = null!;

        [Required]
        public decimal WaterCharges { get; set; } = null!;

        [Required]
        public decimal ParkingCharges { get; set; } = null!;

        [Required]
        public decimal OtherCharges { get; set; } = null!;

        [Required]
        public DateOnly Duedate { get; set; } = null!;

        [Required]
        public decimal MaintainanceAmount { get; set; } = null!;

        [Required]
        public decimal PaidAmount { get; set; } = null!;

        public decimal? UnpaidAmount { get; set; }

        public decimal? TotalAmount { get; set; }

        public string? Discount { get; set; }

        public decimal? Penalty { get; set; }

        [Required]
        public string PayementStatus { get; set; } = null!;

        [Required]
        public string PaymentMode { get; set; } = null!;

        [Required]
        public DateTime PayementDate { get; set; } = null!;

        public string? TransactionReference { get; set; }
    }
}
