using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoMerck.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class locations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAndtime",
                value: new DateTime(2024, 4, 29, 19, 49, 59, 525, DateTimeKind.Local).AddTicks(2646));

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateAndtime",
                value: new DateTime(2024, 4, 29, 19, 49, 59, 525, DateTimeKind.Local).AddTicks(2662));

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateAndtime",
                value: new DateTime(2024, 4, 29, 19, 49, 59, 525, DateTimeKind.Local).AddTicks(2664));

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateAndtime",
                value: new DateTime(2024, 4, 29, 19, 49, 59, 525, DateTimeKind.Local).AddTicks(2665));

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateAndtime",
                value: new DateTime(2024, 4, 29, 19, 49, 59, 525, DateTimeKind.Local).AddTicks(2667));

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateAndtime",
                value: new DateTime(2024, 4, 29, 19, 49, 59, 525, DateTimeKind.Local).AddTicks(2668));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAndtime",
                value: new DateTime(2024, 4, 29, 19, 16, 27, 71, DateTimeKind.Local).AddTicks(4471));

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateAndtime",
                value: new DateTime(2024, 4, 29, 19, 16, 27, 71, DateTimeKind.Local).AddTicks(4487));

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateAndtime",
                value: new DateTime(2024, 4, 29, 19, 16, 27, 71, DateTimeKind.Local).AddTicks(4489));

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateAndtime",
                value: new DateTime(2024, 4, 29, 19, 16, 27, 71, DateTimeKind.Local).AddTicks(4490));

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateAndtime",
                value: new DateTime(2024, 4, 29, 19, 16, 27, 71, DateTimeKind.Local).AddTicks(4492));

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateAndtime",
                value: new DateTime(2024, 4, 29, 19, 16, 27, 71, DateTimeKind.Local).AddTicks(4493));
        }
    }
}
