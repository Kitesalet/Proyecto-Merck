using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoMerck.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class djfgh : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ClinicName",
                table: "Consultations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ClinicName", "DateAndtime" },
                values: new object[] { null, new DateTime(2024, 3, 21, 18, 5, 5, 336, DateTimeKind.Local).AddTicks(4361) });

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ClinicName", "DateAndtime" },
                values: new object[] { null, new DateTime(2024, 3, 21, 18, 5, 5, 336, DateTimeKind.Local).AddTicks(4375) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClinicName",
                table: "Consultations");

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAndtime",
                value: new DateTime(2024, 3, 21, 16, 16, 3, 653, DateTimeKind.Local).AddTicks(5202));

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAndtime",
                value: new DateTime(2024, 3, 21, 16, 16, 3, 653, DateTimeKind.Local).AddTicks(5225));
        }
    }
}
