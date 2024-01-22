using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoMerck.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class first_mig_database_online : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAndtime",
                value: new DateTime(2024, 1, 22, 10, 53, 45, 884, DateTimeKind.Local).AddTicks(6105));

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAndtime",
                value: new DateTime(2024, 1, 22, 10, 53, 45, 884, DateTimeKind.Local).AddTicks(6213));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
