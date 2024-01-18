using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoMerck.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class primeramigrationimanol : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAndtime",
                value: new DateTime(2024, 1, 17, 14, 17, 37, 163, DateTimeKind.Local).AddTicks(3584));

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAndtime",
                value: new DateTime(2024, 1, 17, 14, 17, 37, 163, DateTimeKind.Local).AddTicks(3674));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAndtime",
                value: new DateTime(2024, 1, 17, 14, 12, 50, 8, DateTimeKind.Local).AddTicks(3500));

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAndtime",
                value: new DateTime(2024, 1, 17, 14, 12, 50, 8, DateTimeKind.Local).AddTicks(3597));
        }
    }
}
