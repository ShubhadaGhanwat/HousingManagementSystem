using System;
using System.Collections.Generic;
using HousingManagementSystem.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace HousingManagementSystem.Infrastructure.Persistence;

public partial class SPHMSDbContext : DbContext
{
    public SPHMSDbContext()
    {
    }

    public SPHMSDbContext(DbContextOptions<SPHMSDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Commitee> Commitees { get; set; }

    public virtual DbSet<CommiteeMember> CommiteeMembers { get; set; }

    public virtual DbSet<Complaint> Complaints { get; set; }

    public virtual DbSet<ComplaintCategory> ComplaintCategories { get; set; }

    public virtual DbSet<Event> Events { get; set; }

    public virtual DbSet<EventImage> EventImages { get; set; }

    public virtual DbSet<Facility> Facilities { get; set; }

    public virtual DbSet<FacilityImage> FacilityImages { get; set; }

    public virtual DbSet<Flat> Flats { get; set; }

    public virtual DbSet<MaintainanceBill> MaintainanceBills { get; set; }

    public virtual DbSet<Notice> Notices { get; set; }

    public virtual DbSet<Resident> Residents { get; set; }

    public virtual DbSet<Society> Societies { get; set; }

    public virtual DbSet<Visitor> Visitors { get; set; }

    public virtual DbSet<Wing> Wings { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=LAPTOP-38HVMEN0;Database=SPHMSDb;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Commitee>(entity =>
        {
            entity.HasKey(e => e.CommiteeId).HasName("PK__Commitee__FAD2EFE77C7F5AB1");

            entity.Property(e => e.CreatedAt).HasColumnType("datetime");
            entity.Property(e => e.DeletedAt).HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(80);
            entity.Property(e => e.Position)
                .HasMaxLength(80)
                .IsUnicode(false);
            entity.Property(e => e.RestoredAt).HasColumnType("datetime");
            entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
        });

        modelBuilder.Entity<CommiteeMember>(entity =>
        {
            entity.HasKey(e => e.CommiteeMemberId).HasName("PK__Commitee__E48763874E1FCA9F");

            entity.Property(e => e.CreatedAt).HasColumnType("datetime");
            entity.Property(e => e.DeletedAt).HasColumnType("datetime");
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.HightligtedWork)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Id).HasMaxLength(450);
            entity.Property(e => e.RestoredAt).HasColumnType("datetime");
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
            entity.Property(e => e.WorkingPeriod)
                .HasMaxLength(90)
                .IsUnicode(false);

            entity.HasOne(d => d.Commitee).WithMany(p => p.CommiteeMembers)
                .HasForeignKey(d => d.CommiteeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FKcommiteeid");
        });

        modelBuilder.Entity<Complaint>(entity =>
        {
            entity.HasKey(e => e.ComplaintId).HasName("PK__Complain__740D898F60F7BE9E");

            entity.Property(e => e.ComplaintStatus)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CreatedAt).HasColumnType("datetime");
            entity.Property(e => e.DeletedAt).HasColumnType("datetime");
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Id).HasMaxLength(450);
            entity.Property(e => e.Priority)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Remarks)
                .HasMaxLength(70)
                .IsUnicode(false);
            entity.Property(e => e.RestoredAt).HasColumnType("datetime");
            entity.Property(e => e.Title)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedAt).HasColumnType("datetime");

            entity.HasOne(d => d.ComplaintCategory).WithMany(p => p.Complaints)
                .HasForeignKey(d => d.ComplaintCategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FKComplainid");
        });

        modelBuilder.Entity<ComplaintCategory>(entity =>
        {
            entity.HasKey(e => e.ComplaintCategoryId).HasName("PK__Complain__F5043A629D4089B7");

            entity.Property(e => e.CreatedAt).HasColumnType("datetime");
            entity.Property(e => e.DeletedAt).HasColumnType("datetime");
            entity.Property(e => e.Description)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.RestoredAt).HasColumnType("datetime");
            entity.Property(e => e.Title)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
        });

        modelBuilder.Entity<Event>(entity =>
        {
            entity.HasKey(e => e.EventId).HasName("PK__Events__7944C8104F40A10A");

            entity.Property(e => e.CreatedAt).HasColumnType("datetime");
            entity.Property(e => e.DeletedAt).HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(400);
            entity.Property(e => e.EndTime).HasColumnType("datetime");
            entity.Property(e => e.EventDate).HasColumnType("datetime");
            entity.Property(e => e.EventTitle)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Flag).HasDefaultValue(0);
            entity.Property(e => e.Location)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.RestoredAt).HasColumnType("datetime");
            entity.Property(e => e.StartTime).HasColumnType("datetime");
            entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
        });

        modelBuilder.Entity<EventImage>(entity =>
        {
            entity.HasKey(e => e.EventImageId).HasName("PK__EventIma__9B3A69603F385B29");

            entity.Property(e => e.CreatedAt).HasColumnType("datetime");
            entity.Property(e => e.DeletedAt).HasColumnType("datetime");
            entity.Property(e => e.DisplayOrder).HasDefaultValue(1);
            entity.Property(e => e.Flag).HasDefaultValue(0);
            entity.Property(e => e.ImagePath)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.ImageTitle)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.RestoredAt).HasColumnType("datetime");
            entity.Property(e => e.UpdatedAt).HasColumnType("datetime");

            entity.HasOne(d => d.Event).WithMany(p => p.EventImages)
                .HasForeignKey(d => d.EventId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FKeventid");
        });

        modelBuilder.Entity<Facility>(entity =>
        {
            entity.HasKey(e => e.FacilityId).HasName("PK__Faciliti__5FB08A746291A77F");

            entity.Property(e => e.CreatedAt).HasColumnType("datetime");
            entity.Property(e => e.DeletedAt).HasColumnType("datetime");
            entity.Property(e => e.Description)
                .HasMaxLength(70)
                .IsUnicode(false);
            entity.Property(e => e.FacilityName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Flag).HasDefaultValue(0);
            entity.Property(e => e.RestoredAt).HasColumnType("datetime");
            entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
        });

        modelBuilder.Entity<FacilityImage>(entity =>
        {
            entity.HasKey(e => e.FacilityImageId).HasName("PK__Facility__60B512027B791533");

            entity.Property(e => e.CreatedAt).HasColumnType("datetime");
            entity.Property(e => e.DeletedAt).HasColumnType("datetime");
            entity.Property(e => e.DisplayOrder).HasDefaultValue(1);
            entity.Property(e => e.FacilityImage1)
                .HasMaxLength(800)
                .IsUnicode(false)
                .HasColumnName("FacilityImage");
            entity.Property(e => e.Flag).HasDefaultValue(0);
            entity.Property(e => e.RestoredAt).HasColumnType("datetime");
            entity.Property(e => e.Title)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedAt).HasColumnType("datetime");

            entity.HasOne(d => d.Facility).WithMany(p => p.FacilityImages)
                .HasForeignKey(d => d.FacilityId)
                .HasConstraintName("FKfacilityid");
        });

        modelBuilder.Entity<Flat>(entity =>
        {
            entity.HasKey(e => e.FlatId).HasName("PK__Flats__7CD6EDB19581B3EB");

            entity.Property(e => e.AreaSqft)
                .HasMaxLength(90)
                .IsUnicode(false);
            entity.Property(e => e.CreatedAt).HasColumnType("datetime");
            entity.Property(e => e.DeletedAt).HasColumnType("datetime");
            entity.Property(e => e.Flag).HasDefaultValue(0);
            entity.Property(e => e.FlatNumber)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.FlatType)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.RestoredAt).HasColumnType("datetime");
            entity.Property(e => e.UpdatedAt).HasColumnType("datetime");

            entity.HasOne(d => d.Wing).WithMany(p => p.Flats)
                .HasForeignKey(d => d.WingId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FKFlatid");
        });

        modelBuilder.Entity<MaintainanceBill>(entity =>
        {
            entity.HasKey(e => e.MaintainanceId).HasName("PK__Maintain__BCFFF0A6672A284E");

            entity.Property(e => e.CreatedAt).HasColumnType("datetime");
            entity.Property(e => e.DeletedAt).HasColumnType("datetime");
            entity.Property(e => e.Discount)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Duedate).HasColumnName("DUEDATE");
            entity.Property(e => e.GeneratedAt)
                .HasColumnType("datetime")
                .HasColumnName("GeneratedAT");
            entity.Property(e => e.Id).HasMaxLength(450);
            entity.Property(e => e.MaintainanceAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.OtherCharges).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PaidAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ParkingCharges).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PayementDate).HasColumnType("datetime");
            entity.Property(e => e.PayementStatus)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.PaymentMode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Penalty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.RestoredAt).HasColumnType("datetime");
            entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TransactionReference)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UnpaidAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
            entity.Property(e => e.WaterCharges).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.Flat).WithMany(p => p.MaintainanceBills)
                .HasForeignKey(d => d.FlatId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FKmaintainanceFlatid");

            entity.HasOne(d => d.Wing).WithMany(p => p.MaintainanceBills)
                .HasForeignKey(d => d.WingId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FKmaintainancewingid");
        });

        modelBuilder.Entity<Notice>(entity =>
        {
            entity.HasKey(e => e.NoticeId).HasName("PK__Notices__CE83CBE55BB89DFF");

            entity.Property(e => e.Attachement).HasMaxLength(200);
            entity.Property(e => e.CreatedAt).HasColumnType("datetime");
            entity.Property(e => e.DeletedAt).HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(400);
            entity.Property(e => e.ExpiryDate).HasColumnType("datetime");
            entity.Property(e => e.FeaturedImage).HasMaxLength(300);
            entity.Property(e => e.Flag).HasDefaultValue(0);
            entity.Property(e => e.PublishDate).HasColumnType("datetime");
            entity.Property(e => e.RestoredAt).HasColumnType("datetime");
            entity.Property(e => e.Title)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
        });

        modelBuilder.Entity<Resident>(entity =>
        {
            entity.HasKey(e => e.ResidentId).HasName("PK__Resident__07FB00DC848A7E56");

            entity.Property(e => e.Age)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CreatedAt).HasColumnType("datetime");
            entity.Property(e => e.DeletedAt).HasColumnType("datetime");
            entity.Property(e => e.EmailAddress)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.Flag).HasDefaultValue(0);
            entity.Property(e => e.FullName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Gender)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Id).HasMaxLength(450);
            entity.Property(e => e.MoveInDate).HasColumnType("datetime");
            entity.Property(e => e.MoveOutDate).HasColumnType("datetime");
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ProfilePhoto).HasMaxLength(100);
            entity.Property(e => e.ResidentType)
                .HasMaxLength(80)
                .IsUnicode(false);
            entity.Property(e => e.RestoredAt).HasColumnType("datetime");
            entity.Property(e => e.UpdatedAt).HasColumnType("datetime");

            entity.HasOne(d => d.Flat).WithMany(p => p.Residents)
                .HasForeignKey(d => d.FlatId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FKResidentFlatid");

            entity.HasOne(d => d.Wing).WithMany(p => p.Residents)
                .HasForeignKey(d => d.WingId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FKwingid");
        });

        modelBuilder.Entity<Society>(entity =>
        {
            entity.HasKey(e => e.SocietyId).HasName("PK__Societie__2D7C79FB23DB9A74");

            entity.Property(e => e.Address).HasMaxLength(100);
            entity.Property(e => e.City)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CreatedAt).HasColumnType("datetime");
            entity.Property(e => e.DeletedAt).HasColumnType("datetime");
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DevelopedBy).HasMaxLength(30);
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EstablishedDate).HasColumnType("datetime");
            entity.Property(e => e.Flag).HasDefaultValue(0);
            entity.Property(e => e.Logo)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Phone)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Pincode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.RestoredAt).HasColumnType("datetime");
            entity.Property(e => e.SocietyName).HasMaxLength(40);
            entity.Property(e => e.State)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
        });

        modelBuilder.Entity<Visitor>(entity =>
        {
            entity.HasKey(e => e.VistorId).HasName("PK__Visitors__330323C279F55E07");

            entity.Property(e => e.CreatedAt).HasColumnType("datetime");
            entity.Property(e => e.DeletedAt).HasColumnType("datetime");
            entity.Property(e => e.EntryTime).HasColumnType("datetime");
            entity.Property(e => e.ExitTime).HasColumnType("datetime");
            entity.Property(e => e.Flag).HasDefaultValue(0);
            entity.Property(e => e.FullName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.Purpose)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.Remarks)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.RestoredAt).HasColumnType("datetime");
            entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
            entity.Property(e => e.VehicleNumber)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.VistorType)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.Flat).WithMany(p => p.Visitors)
                .HasForeignKey(d => d.FlatId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FKVistorUserid");
        });

        modelBuilder.Entity<Wing>(entity =>
        {
            entity.HasKey(e => e.WingId).HasName("PK__Wings__A0A84F8ABB428F3F");

            entity.Property(e => e.CreatedAt).HasColumnType("datetime");
            entity.Property(e => e.DeletedAt).HasColumnType("datetime");
            entity.Property(e => e.Flag).HasDefaultValue(0);
            entity.Property(e => e.RestoredAt).HasColumnType("datetime");
            entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
            entity.Property(e => e.WingCode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.WingName)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
