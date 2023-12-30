using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Job_Portal_Project.Models;

public partial class JobportalDbContext : DbContext
{
    public JobportalDbContext()
    {
    }

    public JobportalDbContext(DbContextOptions<JobportalDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Admin> Admins { get; set; }

    public virtual DbSet<Application> Applications { get; set; }

    public virtual DbSet<Job> Jobs { get; set; }

    public virtual DbSet<JobApplicationsApproval> JobApplicationsApprovals { get; set; }

    public virtual DbSet<Message> Messages { get; set; }

    public virtual DbSet<Offer> Offers { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=TAHA\\MSSQLSERVER02;Database=Jobportal-Db;Trusted_Connection=True;TrustServerCertificate=true;MultipleActiveResultSets=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Admin>(entity =>
        {
            entity.HasKey(e => e.AdminId).HasName("PK__Admins__719FE4E8CD2217D0");

            entity.HasIndex(e => e.Email, "UQ__Admins__A9D10534302B637C").IsUnique();

            entity.Property(e => e.AdminId).HasColumnName("AdminID");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.UserType)
                .HasMaxLength(5)
                .HasDefaultValueSql("('admin')");
        });

        modelBuilder.Entity<Application>(entity =>
        {
            entity.HasKey(e => e.ApplicationId).HasName("PK__Applicat__C93A4F7903670DAE");

            entity.HasIndex(e => new { e.JobId, e.ApplicantId }, "UC_ApplicantJob").IsUnique();

            entity.Property(e => e.ApplicationId).HasColumnName("ApplicationID");
            entity.Property(e => e.ApplicantId)
                .IsRequired()
                .HasColumnName("ApplicantID");
            entity.Property(e => e.ApplicationDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.JobId)
                .IsRequired()
                .HasColumnName("JobID");
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .HasDefaultValueSql("('pending')");

            entity.HasOne(d => d.Applicant).WithMany(p => p.Applications)
                .HasForeignKey(d => d.ApplicantId)
                .HasConstraintName("FK__Applicati__Appli__49C3F6B7");

            entity.HasOne(d => d.Job).WithMany(p => p.Applications)
                .HasForeignKey(d => d.JobId)
                .HasConstraintName("FK__Applicati__JobID__48CFD27E");
        });

        modelBuilder.Entity<Job>(entity =>
        {
            entity.HasKey(e => e.JobId).HasName("PK__Jobs__056690E26D982F9B");

            entity.Property(e => e.JobId).HasColumnName("JobID");
            entity.Property(e => e.CompanyName).HasMaxLength(100);
            entity.Property(e => e.DatePosted)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Deadline).HasMaxLength(20);
            entity.Property(e => e.Education).HasMaxLength(20);
            entity.Property(e => e.Experience).HasMaxLength(20);
            entity.Property(e => e.JobTitle).HasMaxLength(100);
            entity.Property(e => e.JobType).HasMaxLength(20);
            entity.Property(e => e.Location).HasMaxLength(100);
            entity.Property(e => e.Requirements).HasMaxLength(255);
            entity.Property(e => e.SalaryRange).HasMaxLength(20);
            entity.Property(e => e.ShiftType).HasMaxLength(10);
            entity.Property(e => e.Skills).HasMaxLength(255);
        });

        modelBuilder.Entity<JobApplicationsApproval>(entity =>
        {
            entity.HasKey(e => e.ApplicationApprovalId).HasName("PK__JobAppli__A45A7F911BBA87C6");

            entity.ToTable("JobApplicationsApproval");

            entity.HasIndex(e => new { e.JobId, e.ApplicantId }, "UC_JobApplication").IsUnique();

            entity.Property(e => e.ApplicationApprovalId).HasColumnName("ApplicationApprovalID");
            entity.Property(e => e.AdminId).HasColumnName("AdminID");
            entity.Property(e => e.ApplicantId).HasColumnName("ApplicantID");
            entity.Property(e => e.ApplicationDate).HasColumnType("datetime");
            entity.Property(e => e.ApprovalDate).HasColumnType("datetime");
            entity.Property(e => e.JobId).HasColumnName("JobID");
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .HasDefaultValueSql("('pending')");

            entity.HasOne(d => d.Admin).WithMany(p => p.JobApplicationsApprovals)
                .HasForeignKey(d => d.AdminId)
                .HasConstraintName("FK__JobApplic__Admin__5165187F");

            entity.HasOne(d => d.Applicant).WithMany(p => p.JobApplicationsApprovals)
                .HasForeignKey(d => d.ApplicantId)
                .HasConstraintName("FK__JobApplic__Appli__52593CB8");

            entity.HasOne(d => d.Job).WithMany(p => p.JobApplicationsApprovals)
                .HasForeignKey(d => d.JobId)
                .HasConstraintName("FK__JobApplic__JobID__5070F446");

            entity.HasOne(d => d.Application).WithOne(p => p.JobApplicationsApproval)
                .HasPrincipalKey<Application>(p => new { p.JobId, p.ApplicantId })
                .HasForeignKey<JobApplicationsApproval>(d => new { d.JobId, d.ApplicantId })
                .HasConstraintName("FK__JobApplicationsA__5535A963");
        });

        modelBuilder.Entity<Message>(entity =>
        {
            entity.HasKey(e => e.MessageId).HasName("PK__Messages__C87C037CACD743BF");

            entity.Property(e => e.MessageId).HasColumnName("MessageID");
            entity.Property(e => e.MessageText).HasMaxLength(1000);
            entity.Property(e => e.SenderEmail).HasMaxLength(100);
            entity.Property(e => e.SenderName).HasMaxLength(50);
            entity.Property(e => e.SenderNum).HasMaxLength(11);
            entity.Property(e => e.SenderRole).HasMaxLength(20);
            entity.Property(e => e.Timestamp)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<Offer>(entity =>
        {
            entity.HasKey(e => e.OfferId).HasName("PK__Offers__8EBCF0B1F0D44759");

            entity.HasIndex(e => new { e.JobId, e.ApplicantId }, "UC_JobApplicantOffer").IsUnique();

            entity.Property(e => e.OfferId).HasColumnName("OfferID");
            entity.Property(e => e.ApplicantId).HasColumnName("ApplicantID");
            entity.Property(e => e.JobId).HasColumnName("JobID");
            entity.Property(e => e.OfferAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.OfferDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .HasDefaultValueSql("('pending')");

            entity.HasOne(d => d.Applicant).WithMany(p => p.Offers)
                .HasForeignKey(d => d.ApplicantId)
                .HasConstraintName("FK__Offers__Applican__59FA5E80");

            entity.HasOne(d => d.Job).WithMany(p => p.Offers)
                .HasForeignKey(d => d.JobId)
                .HasConstraintName("FK__Offers__JobID__59063A47");

            entity.HasOne(d => d.Application).WithOne(p => p.Offer)
                .HasPrincipalKey<Application>(p => new { p.JobId, p.ApplicantId })
                .HasForeignKey<Offer>(d => new { d.JobId, d.ApplicantId })
                .HasConstraintName("FK__Offers__5DCAEF64");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__Users__1788CCACC69786D4");

            entity.HasIndex(e => e.Email, "UQ__Users__A9D10534898CBC33").IsUnique();

            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.UserType)
                .HasMaxLength(5)
                .HasDefaultValueSql("('user')");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
