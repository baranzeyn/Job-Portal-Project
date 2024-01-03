using Job_Portal_Project.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Job_Portal_Project.Config
{
    public class ApplicationConfig : IEntityTypeConfiguration<Application>
    {
        public void Configure(EntityTypeBuilder<Application> builder)
        {
            builder.HasKey(e => e.ApplicationId).HasName("PK__Applicat__C93A4F7903670DAE");

            builder.HasIndex(e => new { e.JobId, e.ApplicantId }, "UC_ApplicantJob").IsUnique();

            builder.Property(e => e.ApplicationId).HasColumnName("ApplicationID");
            builder.Property(e => e.ApplicantId)
                .IsRequired()
                .HasColumnName("ApplicantID");
            builder.Property(e => e.ApplicationDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            builder.Property(e => e.JobId)
                .IsRequired()
                .HasColumnName("JobID");
            builder.Property(e => e.Status)
                .HasMaxLength(20)
                .HasDefaultValueSql("('pending')");

            builder.HasOne(d => d.Job).WithMany(p => p.Applications)
                .HasForeignKey(d => d.JobId)
                .HasConstraintName("FK__Applicati__JobID__48CFD27E");
        }
    }
}