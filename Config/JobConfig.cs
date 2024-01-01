using Job_Portal_Project.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Job_Portal_Project.Config
{
    public class JobConfig : IEntityTypeConfiguration<Job>
    {
        public void Configure(EntityTypeBuilder<Job> builder)
        {
            builder.HasKey(e => e.JobId).HasName("PK__Jobs__056690E26D982F9B");

            builder.Property(e => e.JobId).HasColumnName("JobID");
            builder.Property(e => e.CompanyName).HasMaxLength(100);
            builder.Property(e => e.DatePosted)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            builder.Property(e => e.Deadline).HasMaxLength(20);
            builder.Property(e => e.Education).HasMaxLength(20);
            builder.Property(e => e.Experience).HasMaxLength(20);
            builder.Property(e => e.JobTitle).HasMaxLength(100);
            builder.Property(e => e.Location).HasMaxLength(100);
            builder.Property(e => e.Requirements).HasMaxLength(255);
            builder.Property(e => e.SalaryRange).HasMaxLength(20);
            builder.Property(e => e.ShiftType).HasMaxLength(10);
            builder.Property(e => e.Skills).HasMaxLength(255);
        }
    }
}