using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Job_Portal_Project.Repositories
{
    public class IdentityRoleConfig : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole() {Name="User", NormalizedName="USER"},
                new IdentityRole() {Name="Employer", NormalizedName="EMPLOYER"},
                new IdentityRole() {Name="Admin", NormalizedName="ADMIN", ConcurrencyStamp = Guid.NewGuid().ToString()}
                
            );
        }
    }
}