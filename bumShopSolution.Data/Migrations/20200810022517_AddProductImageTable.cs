using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace bumShopSolution.Data.Migrations
{
    public partial class AddProductImageTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 8, 5, 16, 24, 5, 676, DateTimeKind.Local).AddTicks(9391));

            migrationBuilder.CreateTable(
                name: "ProductImages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(nullable: false),
                    ImagePath = table.Column<string>(maxLength: 200, nullable: false),
                    Caption = table.Column<string>(maxLength: 200, nullable: true),
                    IsDefault = table.Column<bool>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    SortOrder = table.Column<int>(nullable: false),
                    FileSize = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductImages_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ProductId",
                table: "ProductImages",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductImages");

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 8, 5, 16, 24, 5, 676, DateTimeKind.Local).AddTicks(9391),
                oldClrType: typeof(DateTime));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("a2719ce9-f1e5-41aa-8d0e-860995ef33c7"),
                column: "ConcurrencyStamp",
                value: "cb8ceaca-a4e6-48b7-8c24-3cbdce98e2da");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("e148f6c4-9281-474e-866d-f306b11399d1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6b63fcc0-30d0-4baa-a5da-e417004ba0a7", "AQAAAAEAACcQAAAAEDithsNPQ0Wejt7cs4atbmnSjvj4zC89VZTcMT5NYZqlFRZXoKcn2Tr8F9qTBYmLTQ==" });
        }
    }
}
