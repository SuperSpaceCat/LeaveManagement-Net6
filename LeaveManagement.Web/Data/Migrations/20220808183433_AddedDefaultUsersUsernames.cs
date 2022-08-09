using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedDefaultUsersUsernames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "6e57c9af-b135-450a-bb80-ce1a5e61f80f", true, "USER@LOCALHOST.COM", "AQAAAAEAACcQAAAAEGrTRYoNG/CK6MovozoeKLkVwPOByPa0aMrv33TYsmcJ83CFkqEoF9abs1dKu8n5RA==", "cd494aba-ad9a-49b3-9937-a6a24381f974", "user@localhost.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e4a5adfe-613e-4e4c-9b18-08b676fe557c",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "693f0663-a61f-440f-9274-f481dc939e3c", true, "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAEKMOTNVfD+Tf58iz8WxcGgPsvUajEsi7xJEGWyLpKHImF6J6PMOdZh8Gw+Acn/B39Q==", "58df445d-fc05-4f34-a595-5ed81fb78475", "admin@localhost.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "l3b5ad7e-463e-464c-81b9-0l672d5f524c",
                column: "ConcurrencyStamp",
                value: "cf7d966c-f0d3-4131-a00f-9d04d5033418");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "l3b9f3ce-8b83-6d4e-83f9-09d637a6b23l",
                column: "ConcurrencyStamp",
                value: "d6b2b84e-c553-44e0-b567-a1d0ebea8242");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a58a11df-9db8-4452-8f5f-243ca14b8a24",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "7ea54e31-dfed-43b1-9caa-4d55c6b187a8", false, null, "AQAAAAEAACcQAAAAEFZpMGB2e168PbI7t66bg3u9sWea3aCDSrMrCxx7ep9L+DPqJyYWsHh9lvpfPGlsMQ==", "56c307a7-81e8-4085-8ecd-aa8029b7b08d", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e4a5adfe-613e-4e4c-9b18-08b676fe557c",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "39be4487-1776-49bc-8846-025f6150e186", false, null, "AQAAAAEAACcQAAAAEENC3ZgaQhQSggdZH8KAG0PQ6akf9kMrstyLr/4QTEzt5H2m+bXWib0ODH0E5pIKrw==", "cdaf8b0e-dfb3-44f7-ae00-0a49390380d6", null });
        }
    }
}
