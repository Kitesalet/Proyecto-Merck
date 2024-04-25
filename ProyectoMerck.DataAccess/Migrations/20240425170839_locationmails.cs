using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoMerck.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class locationmails : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Locations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAndtime",
                value: new DateTime(2024, 4, 25, 14, 8, 39, 10, DateTimeKind.Local).AddTicks(6154));

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateAndtime",
                value: new DateTime(2024, 4, 25, 14, 8, 39, 10, DateTimeKind.Local).AddTicks(6170));

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateAndtime",
                value: new DateTime(2024, 4, 25, 14, 8, 39, 10, DateTimeKind.Local).AddTicks(6171));

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateAndtime",
                value: new DateTime(2024, 4, 25, 14, 8, 39, 10, DateTimeKind.Local).AddTicks(6173));

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateAndtime",
                value: new DateTime(2024, 4, 25, 14, 8, 39, 10, DateTimeKind.Local).AddTicks(6175));

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateAndtime",
                value: new DateTime(2024, 4, 25, 14, 8, 39, 10, DateTimeKind.Local).AddTicks(6177));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1,
                column: "Email",
                value: "mercktest111@gmail.com");

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2,
                column: "Email",
                value: "mercktest111@gmail.com");

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3,
                column: "Email",
                value: "mercktest111@gmail.com");

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 4,
                column: "Email",
                value: "mercktest111@gmail.com");

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 5,
                column: "Email",
                value: "mercktest111@gmail.com");

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 6,
                column: "Email",
                value: "mercktest111@gmail.com");

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 7,
                column: "Email",
                value: "mercktest111@gmail.com");

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 8,
                column: "Email",
                value: "mercktest111@gmail.com");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Locations");

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAndtime",
                value: new DateTime(2024, 3, 21, 19, 23, 57, 510, DateTimeKind.Local).AddTicks(3594));

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateAndtime",
                value: new DateTime(2024, 3, 21, 19, 23, 57, 510, DateTimeKind.Local).AddTicks(3610));

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateAndtime",
                value: new DateTime(2024, 3, 21, 19, 23, 57, 510, DateTimeKind.Local).AddTicks(3611));

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateAndtime",
                value: new DateTime(2024, 3, 21, 19, 23, 57, 510, DateTimeKind.Local).AddTicks(3613));

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateAndtime",
                value: new DateTime(2024, 3, 21, 19, 23, 57, 510, DateTimeKind.Local).AddTicks(3657));

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateAndtime",
                value: new DateTime(2024, 3, 21, 19, 23, 57, 510, DateTimeKind.Local).AddTicks(3659));
        }
    }
}
