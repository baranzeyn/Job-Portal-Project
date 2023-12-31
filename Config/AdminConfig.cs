using Job_Portal_Project.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Job_Portal_Project.Config
{
    public class AdminConfig : IEntityTypeConfiguration<Admin>
    {
        public void Configure(EntityTypeBuilder<Admin> builder)
        {
            builder.HasKey(e => e.AdminId).HasName("PK__Admins__719FE4E8CD2217D0");

            builder.HasIndex(e => e.Email, "UQ__Admins__A9D10534302B637C").IsUnique();

            builder.Property(e => e.AdminId).HasColumnName("AdminID");
            builder.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            builder.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(false);
            builder.Property(e => e.LastName)
                .HasMaxLength(50)
                .IsUnicode(false);
            builder.Property(e => e.Password)
                .HasMaxLength(255)
                .IsUnicode(false);
            builder.Property(e => e.UserType)
                .HasMaxLength(5)
                .HasDefaultValueSql("('admin')");
        }
    }
}