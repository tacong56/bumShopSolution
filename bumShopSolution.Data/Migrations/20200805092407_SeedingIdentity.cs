using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace bumShopSolution.Data.Migrations
{
    public partial class SeedingIdentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                nullable: false,
                defaultValue: new DateTime(2020, 8, 5, 16, 24, 5, 676, DateTimeKind.Local).AddTicks(9391),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 23, 10, 59, 20, 26, DateTimeKind.Local).AddTicks(2878));

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("a2719ce9-f1e5-41aa-8d0e-860995ef33c7"), "cb8ceaca-a4e6-48b7-8c24-3cbdce98e2da", "Admintrator role", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { new Guid("e148f6c4-9281-474e-866d-f306b11399d1"), new Guid("a2719ce9-f1e5-41aa-8d0e-860995ef33c7") });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("e148f6c4-9281-474e-866d-f306b11399d1"), 0, "6b63fcc0-30d0-4baa-a5da-e417004ba0a7", new DateTime(1997, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "tacong56@gmail.com", true, "Ta", "Cong", false, null, "tacong56@gmail.com", "admin", "AQAAAAEAACcQAAAAEDithsNPQ0Wejt7cs4atbmnSjvj4zC89VZTcMT5NYZqlFRZXoKcn2Tr8F9qTBYmLTQ==", null, false, "", false, "admin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("a2719ce9-f1e5-41aa-8d0e-860995ef33c7"));

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("e148f6c4-9281-474e-866d-f306b11399d1"), new Guid("a2719ce9-f1e5-41aa-8d0e-860995ef33c7") });

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("e148f6c4-9281-474e-866d-f306b11399d1"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 23, 10, 59, 20, 26, DateTimeKind.Local).AddTicks(2878),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 8, 5, 16, 24, 5, 676, DateTimeKind.Local).AddTicks(9391));
        }
    }
}
