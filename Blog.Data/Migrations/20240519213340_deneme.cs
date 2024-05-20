using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blog.Data.Migrations
{
    /// <inheritdoc />
    public partial class deneme : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Authors");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("56f58f96-3b2c-4339-ba5d-f3bd0c70d388"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 20, 0, 33, 37, 981, DateTimeKind.Local).AddTicks(4951));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5dee7f5a-78ed-42b6-9f79-9816505f9c38"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 20, 0, 33, 37, 981, DateTimeKind.Local).AddTicks(7205));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("f3c8d4ae-3456-4f8c-88aa-16f3d5e2a60c"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 20, 0, 33, 37, 981, DateTimeKind.Local).AddTicks(9404));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Authors",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("56f58f96-3b2c-4339-ba5d-f3bd0c70d388"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 19, 21, 31, 37, 64, DateTimeKind.Local).AddTicks(3483));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("a4d9e5af-4567-4f0c-9edc-8a2d9f25a7b8"),
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5dee7f5a-78ed-42b6-9f79-9816505f9c38"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 19, 21, 31, 37, 64, DateTimeKind.Local).AddTicks(5714));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("f3c8d4ae-3456-4f8c-88aa-16f3d5e2a60c"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 19, 21, 31, 37, 64, DateTimeKind.Local).AddTicks(8219));
        }
    }
}
