using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoMerck.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class nuller : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAndtime",
                value: new DateTime(2024, 4, 29, 19, 53, 59, 801, DateTimeKind.Local).AddTicks(7308));

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateAndtime",
                value: new DateTime(2024, 4, 29, 19, 53, 59, 801, DateTimeKind.Local).AddTicks(7325));

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateAndtime",
                value: new DateTime(2024, 4, 29, 19, 53, 59, 801, DateTimeKind.Local).AddTicks(7327));

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateAndtime",
                value: new DateTime(2024, 4, 29, 19, 53, 59, 801, DateTimeKind.Local).AddTicks(7328));

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateAndtime",
                value: new DateTime(2024, 4, 29, 19, 53, 59, 801, DateTimeKind.Local).AddTicks(7330));

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateAndtime",
                value: new DateTime(2024, 4, 29, 19, 53, 59, 801, DateTimeKind.Local).AddTicks(7332));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
