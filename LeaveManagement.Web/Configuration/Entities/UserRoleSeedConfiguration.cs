using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configuration.Entities
{
    internal class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<Microsoft.AspNetCore.Identity.IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "l3b5ad7e-463e-464c-81b9-0l672d5f524c",
                    UserId = "e4a5adfe-613e-4e4c-9b18-08b676fe557c"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "l3b9f3ce-8b83-6d4e-83f9-09d637a6b23l",
                    UserId = "a58a11df-9db8-4452-8f5f-243ca14b8a24"
                }
                );
        }
    }
}