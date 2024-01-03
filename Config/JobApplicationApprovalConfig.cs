using Job_Portal_Project.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Job_Portal_Project.Config
{
    public class JobApplicationApprovalConfig : IEntityTypeConfiguration<JobApplicationsApproval>
    {
        public void Configure(EntityTypeBuilder<JobApplicationsApproval> builder)
        {
            builder.HasKey(e => e.ApplicationApprovalId).HasName("PK__JobAppli__A45A7F911BBA87C6");

            builder.ToTable("JobApplicationsApproval");

            builder.HasIndex(e => new { e.JobId, e.ApplicantId }, "UC_JobApplication").IsUnique();

            builder.Property(e => e.ApplicationApprovalId).HasColumnName("ApplicationApprovalID");
            builder.Property(e => e.AdminId).HasColumnName("AdminID");
            builder.Property(e => e.ApplicantId).HasColumnName("ApplicantID");
            builder.Property(e => e.ApplicationDate).HasColumnType("datetime");
            builder.Property(e => e.ApprovalDate).HasColumnType("datetime");
            builder.Property(e => e.JobId).HasColumnName("JobID");
            builder.Property(e => e.Status)
                .HasMaxLength(20)
                .HasDefaultValueSql("('pending')");

            builder.HasOne(d => d.Admin).WithMany(p => p.JobApplicationsApprovals)
                .HasForeignKey(d => d.AdminId)
                .HasConstraintName("FK__JobApplic__Admin__5165187F");

            builder.HasOne(d => d.Applicant).WithMany(p => p.JobApplicationsApprovals)
                .HasForeignKey(d => d.ApplicantId)
                .HasConstraintName("FK__JobApplic__Appli__52593CB8");

            builder.HasOne(d => d.Job).WithMany(p => p.JobApplicationsApprovals)
                .HasForeignKey(d => d.JobId)
                .HasConstraintName("FK__JobApplic__JobID__5070F446");

            builder.HasOne(d => d.Application)
            .WithOne(p => p.JobApplicationsApproval)
            .HasPrincipalKey<Application>(p => new { p.JobId, p.ApplicantId })
            .HasForeignKey<JobApplicationsApproval>(d => new { d.JobId, d.ApplicantId })
            .HasConstraintName("FK__JobApplicationsA__5535A963");
        }
    }
}