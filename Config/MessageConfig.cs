using Job_Portal_Project.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Job_Portal_Project.Config
{
    public class MessageConfig : IEntityTypeConfiguration<Message>
    {
        public void Configure(EntityTypeBuilder<Message> builder)
        {
            builder.HasKey(e => e.MessageId).HasName("PK__Messages__C87C037CACD743BF");
            builder.Property(e => e.MessageId).HasColumnName("MessageID");
            builder.Property(e => e.MessageText).HasMaxLength(1000);
            builder.Property(e => e.SenderEmail).HasMaxLength(100);
            builder.Property(e => e.SenderName).HasMaxLength(50);
            builder.Property(e => e.SenderNum).HasMaxLength(11);
            builder.Property(e => e.SenderRole).HasMaxLength(20);
            builder.Property(e => e.Timestamp)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        }
    }
}