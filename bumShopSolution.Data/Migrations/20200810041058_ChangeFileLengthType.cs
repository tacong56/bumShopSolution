using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace bumShopSolution.Data.Migrations
{
    public partial class ChangeFileLengthType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "FileSize",
                table: "ProductImages",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("a2719ce9-f1e5-41aa-8d0e-860995ef33c7"),
                column: "ConcurrencyStamp",
                value: "0257d674-c11a-4b1f-b69f-d49c09e20372");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("e148f6c4-9281-474e-866d-f306b11399d1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b682d600-c249-4639-9358-164d4c14c827", "AQAAAAEAACcQAAAAEIgZ3j/TX3zEZVnANeTORX8whDDIwuU2otGbG9Oq+xGqK5e066QE3i1Z369nxiMoNg==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "FileSize",
                table: "ProductImages",
                type: "int",
                nullable: false,
                oldClrType: typeof(long));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("a2719ce9-f1e5-41aa-8d0e-860995ef33c7"),
                column: "ConcurrencyStamp",
                value: "d2184276-c7fe-4434-974b-374b8cb0be28");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("e148f6c4-9281-474e-866d-f306b11399d1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "07f8f6bd-a8ac-49ef-813f-bd6b87cb0650", "AQAAAAEAACcQAAAAEFlYwSzZopY0Dk8Q77x+MgzOIPFUMAlk6DvWtA36H4YpHXjM+FlZn7FKDRYUQvxoFQ==" });
        }
    }
}
