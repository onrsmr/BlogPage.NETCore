using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blog.Data.Migrations
{
    /// <inheritdoc />
    public partial class raco : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("56f58f96-3b2c-4339-ba5d-f3bd0c70d388"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 19, 21, 24, 24, 753, DateTimeKind.Local).AddTicks(1793));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5dee7f5a-78ed-42b6-9f79-9816505f9c38"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 19, 21, 24, 24, 753, DateTimeKind.Local).AddTicks(3967));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("f3c8d4ae-3456-4f8c-88aa-16f3d5e2a60c"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 19, 21, 24, 24, 753, DateTimeKind.Local).AddTicks(6263));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("56f58f96-3b2c-4339-ba5d-f3bd0c70d388"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 18, 19, 23, 34, 259, DateTimeKind.Local).AddTicks(7403));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5dee7f5a-78ed-42b6-9f79-9816505f9c38"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 18, 19, 23, 34, 259, DateTimeKind.Local).AddTicks(9527));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("f3c8d4ae-3456-4f8c-88aa-16f3d5e2a60c"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 18, 19, 23, 34, 260, DateTimeKind.Local).AddTicks(1558));
        }
    }
}
