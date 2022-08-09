using LeaveManagement.Web.Constants;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagement.Web.Configurations.Entities
{
    public class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {
                    Id = "l3b5ad7e-463e-464c-81b9-0l672d5f524c",
                    Name = Roles.Administrator,
                    NormalizedName = Roles.Administrator.ToUpper()

                    /*
                    Took administrator GUID: e4a5adfe-613e-4e4c-9b18-08b676fe557c, changed values, hexadecimal goes up to f
                    */
                },

                new IdentityRole
                {
                    Id = "l3b9f3ce-8b83-6d4e-83f9-09d637a6b23l",
                    Name = Roles.User,
                    NormalizedName = Roles.User.ToUpper()

                    /*
                    Took administrator GUID: e4a5adfe-613e-4e4c-9b18-08b676fe557c, changed values
                    */
                }
                ); ;
        }
    }
}