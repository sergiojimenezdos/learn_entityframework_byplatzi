using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace projectef.Migrations
{
    /// <inheritdoc />
    public partial class InitialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Task",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Category",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "Description", "Name", "Priotity" },
                values: new object[,]
                {
                    { new Guid("f54b9320-807c-4c3d-867c-b98522e2c6ac"), null, "Personal tasks", 5 },
                    { new Guid("fbc0708d-e650-4f8b-9be4-da4d57496276"), null, "Pending tasks", 2 }
                });

            migrationBuilder.InsertData(
                table: "Task",
                columns: new[] { "TaskId", "CategoryId", "CreationDate", "Description", "Priority", "Title" },
                values: new object[,]
                {
                    { new Guid("fbc0708d-e650-4f8b-9be4-da4d57496295"), new Guid("fbc0708d-e650-4f8b-9be4-da4d57496276"), new DateTime(2024, 2, 27, 7, 37, 34, 725, DateTimeKind.Local).AddTicks(7556), null, 1, "Payment of public services" },
                    { new Guid("fbc0708d-e650-4f8b-9be4-da4d57496296"), new Guid("f54b9320-807c-4c3d-867c-b98522e2c6ac"), new DateTime(2024, 2, 27, 7, 37, 34, 725, DateTimeKind.Local).AddTicks(7605), null, 0, "Netflix movie" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "TaskId",
                keyValue: new Guid("fbc0708d-e650-4f8b-9be4-da4d57496295"));

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "TaskId",
                keyValue: new Guid("fbc0708d-e650-4f8b-9be4-da4d57496296"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: new Guid("f54b9320-807c-4c3d-867c-b98522e2c6ac"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: new Guid("fbc0708d-e650-4f8b-9be4-da4d57496276"));

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Task",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Category",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
