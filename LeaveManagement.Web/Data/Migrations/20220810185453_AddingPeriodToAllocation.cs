using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddingPeriodToAllocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "l3b5ad7e-463e-464c-81b9-0l672d5f524c",
                column: "ConcurrencyStamp",
                value: "3507a94a-22ac-4779-b2db-9379a73f2b83");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "l3b9f3ce-8b83-6d4e-83f9-09d637a6b23l",
                column: "ConcurrencyStamp",
                value: "97782d61-0609-4782-b4c1-e559061fcd2e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a58a11df-9db8-4452-8f5f-243ca14b8a24",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e0c400e2-8247-4232-811a-b110f5fd1093", "AQAAAAEAACcQAAAAEODsUX16G5G6YD1IZhoXKmblUeHlJdKu+SfOmzJLZgnpSJGOZCsY7UlO9d3NnCvzrQ==", "2c611d90-0c81-42ab-b1af-f4651be82567" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e4a5adfe-613e-4e4c-9b18-08b676fe557c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3eb5c6e8-dfd1-4a25-be1a-92b59ac89fe6", "AQAAAAEAACcQAAAAEOGDvyV80j6ez9ncERb8z9IqXT8EZRbtTt5IBSHsmmvgTRgLVXEqw1NBjtl5FusDUQ==", "969ed81a-a3aa-4acc-9f3b-e76721207dd0" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocations");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "l3b5ad7e-463e-464c-81b9-0l672d5f524c",
                column: "ConcurrencyStamp",
                value: "bdc4e697-8840-43b4-8915-b2a60a10da42");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "l3b9f3ce-8b83-6d4e-83f9-09d637a6b23l",
                column: "ConcurrencyStamp",
                value: "472ab9cb-9683-4c07-a31d-f221c9d6a84a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a58a11df-9db8-4452-8f5f-243ca14b8a24",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6e57c9af-b135-450a-bb80-ce1a5e61f80f", "AQAAAAEAACcQAAAAEGrTRYoNG/CK6MovozoeKLkVwPOByPa0aMrv33TYsmcJ83CFkqEoF9abs1dKu8n5RA==", "cd494aba-ad9a-49b3-9937-a6a24381f974" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e4a5adfe-613e-4e4c-9b18-08b676fe557c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "693f0663-a61f-440f-9274-f481dc939e3c", "AQAAAAEAACcQAAAAEKMOTNVfD+Tf58iz8WxcGgPsvUajEsi7xJEGWyLpKHImF6J6PMOdZh8Gw+Acn/B39Q==", "58df445d-fc05-4f34-a595-5ed81fb78475" });
        }
    }
}
