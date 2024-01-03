using Job_Portal_Project.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Job_Portal_Project.Config
{
    public class OfferConfig : IEntityTypeConfiguration<Offer>
    {
        public void Configure(EntityTypeBuilder<Offer> builder)
        {
            builder.HasKey(e => e.OfferId).HasName("PK__Offers__8EBCF0B1F0D44759");

            builder.HasIndex(e => new { e.JobId, e.ApplicantId }, "UC_JobApplicantOffer").IsUnique();

            builder.Property(e => e.OfferId).HasColumnName("OfferID");
            builder.Property(e => e.ApplicantId).HasColumnName("ApplicantID");
            builder.Property(e => e.JobId).HasColumnName("JobID");
            builder.Property(e => e.OfferAmount).HasColumnType("decimal(18, 2)");
            builder.Property(e => e.OfferDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            builder.Property(e => e.Status)
                .HasMaxLength(20)
                .HasDefaultValueSql("('pending')");

            builder.HasOne(d => d.Job).WithMany(p => p.Offers)
                .HasForeignKey(d => d.JobId)
                .HasConstraintName("FK__Offers__JobID__59063A47");

            builder.HasOne(d => d.Application).WithOne(p => p.Offer)
                .HasPrincipalKey<Application>(p => new { p.JobId, p.ApplicantId })
                .HasForeignKey<Offer>(d => new { d.JobId, d.ApplicantId })
                .HasConstraintName("FK__Offers__5DCAEF64");
        }
    }
}