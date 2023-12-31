using Job_Portal_Project.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Job_Portal_Project.Config
{
    public class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(e => e.UserId).HasName("PK__Users__1788CCACC69786D4");

            builder.HasIndex(e => e.Email, "UQ__Users__A9D10534898CBC33").IsUnique();

            builder.Property(e => e.UserId).HasColumnName("UserID");
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
                .HasDefaultValueSql("('user')");
        }
    }
}