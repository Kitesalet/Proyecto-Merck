using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoMerck.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class newEdadPlanField : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateAndtime",
                table: "AgePlans",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAndtime",
                value: new DateTime(2024, 5, 15, 13, 12, 37, 818, DateTimeKind.Local).AddTicks(4635));

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateAndtime",
                value: new DateTime(2024, 5, 15, 13, 12, 37, 818, DateTimeKind.Local).AddTicks(4656));

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateAndtime",
                value: new DateTime(2024, 5, 15, 13, 12, 37, 818, DateTimeKind.Local).AddTicks(4658));

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateAndtime",
                value: new DateTime(2024, 5, 15, 13, 12, 37, 818, DateTimeKind.Local).AddTicks(4660));

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateAndtime",
                value: new DateTime(2024, 5, 15, 13, 12, 37, 818, DateTimeKind.Local).AddTicks(4662));

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateAndtime",
                value: new DateTime(2024, 5, 15, 13, 12, 37, 818, DateTimeKind.Local).AddTicks(4664));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateAndtime",
                table: "AgePlans");

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAndtime",
                value: new DateTime(2024, 5, 15, 12, 56, 16, 680, DateTimeKind.Local).AddTicks(9970));

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateAndtime",
                value: new DateTime(2024, 5, 15, 12, 56, 16, 681, DateTimeKind.Local).AddTicks(6));

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateAndtime",
                value: new DateTime(2024, 5, 15, 12, 56, 16, 681, DateTimeKind.Local).AddTicks(9));

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateAndtime",
                value: new DateTime(2024, 5, 15, 12, 56, 16, 681, DateTimeKind.Local).AddTicks(11));

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateAndtime",
                value: new DateTime(2024, 5, 15, 12, 56, 16, 681, DateTimeKind.Local).AddTicks(14));

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateAndtime",
                value: new DateTime(2024, 5, 15, 12, 56, 16, 681, DateTimeKind.Local).AddTicks(16));
        }
    }
}
