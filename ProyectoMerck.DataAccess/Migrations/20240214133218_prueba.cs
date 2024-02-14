using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoMerck.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class prueba : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAndtime",
                value: new DateTime(2024, 2, 14, 10, 32, 18, 305, DateTimeKind.Local).AddTicks(9611));

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAndtime",
                value: new DateTime(2024, 2, 14, 10, 32, 18, 305, DateTimeKind.Local).AddTicks(9700));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAndtime",
                value: new DateTime(2024, 1, 25, 4, 1, 11, 735, DateTimeKind.Local).AddTicks(8009));

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAndtime",
                value: new DateTime(2024, 1, 25, 4, 1, 11, 735, DateTimeKind.Local).AddTicks(8101));
        }
    }
}
