using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoMerck.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class newer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAndtime",
                value: new DateTime(2024, 2, 23, 12, 5, 52, 338, DateTimeKind.Local).AddTicks(1071));

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAndtime",
                value: new DateTime(2024, 2, 23, 12, 5, 52, 338, DateTimeKind.Local).AddTicks(1169));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAndtime",
                value: new DateTime(2024, 2, 22, 17, 0, 28, 457, DateTimeKind.Local).AddTicks(3644));

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAndtime",
                value: new DateTime(2024, 2, 22, 17, 0, 28, 457, DateTimeKind.Local).AddTicks(3736));
        }
    }
}
