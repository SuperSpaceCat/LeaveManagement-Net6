using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedDefaultUsersAndRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "l3b5ad7e-463e-464c-81b9-0l672d5f524c", "cf7d966c-f0d3-4131-a00f-9d04d5033418", "Administrator", "ADMINISTRATOR" },
                    { "l3b9f3ce-8b83-6d4e-83f9-09d637a6b23l", "d6b2b84e-c553-44e0-b567-a1d0ebea8242", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "a58a11df-9db8-4452-8f5f-243ca14b8a24", 0, "7ea54e31-dfed-43b1-9caa-4d55c6b187a8", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@localhost.com", false, "System", "User", false, null, "USER@LOCALHOST.COM", null, "AQAAAAEAACcQAAAAEFZpMGB2e168PbI7t66bg3u9sWea3aCDSrMrCxx7ep9L+DPqJyYWsHh9lvpfPGlsMQ==", null, false, "56c307a7-81e8-4085-8ecd-aa8029b7b08d", null, false, null },
                    { "e4a5adfe-613e-4e4c-9b18-08b676fe557c", 0, "39be4487-1776-49bc-8846-025f6150e186", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@localhost.com", false, "System", "Admin", false, null, "ADMIN@LOCALHOST.COM", null, "AQAAAAEAACcQAAAAEENC3ZgaQhQSggdZH8KAG0PQ6akf9kMrstyLr/4QTEzt5H2m+bXWib0ODH0E5pIKrw==", null, false, "cdaf8b0e-dfb3-44f7-ae00-0a49390380d6", null, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "l3b9f3ce-8b83-6d4e-83f9-09d637a6b23l", "a58a11df-9db8-4452-8f5f-243ca14b8a24" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "l3b5ad7e-463e-464c-81b9-0l672d5f524c", "e4a5adfe-613e-4e4c-9b18-08b676fe557c" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "l3b9f3ce-8b83-6d4e-83f9-09d637a6b23l", "a58a11df-9db8-4452-8f5f-243ca14b8a24" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "l3b5ad7e-463e-464c-81b9-0l672d5f524c", "e4a5adfe-613e-4e4c-9b18-08b676fe557c" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "l3b5ad7e-463e-464c-81b9-0l672d5f524c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "l3b9f3ce-8b83-6d4e-83f9-09d637a6b23l");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a58a11df-9db8-4452-8f5f-243ca14b8a24");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e4a5adfe-613e-4e4c-9b18-08b676fe557c");
        }
    }
}
