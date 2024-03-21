using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProyectoMerck.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class d : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ClinicName", "DateAndtime" },
                values: new object[] { "HIALITUS", new DateTime(2024, 3, 21, 19, 23, 1, 586, DateTimeKind.Local).AddTicks(8390) });

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ClinicName", "DateAndtime" },
                values: new object[] { "CRECER", new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Consultations",
                columns: new[] { "Id", "ClinicName", "ConsultationReason", "DateAndtime", "SelectedLocationIndex", "Url" },
                values: new object[,]
                {
                    { 3, "HOSPITAL ITALIANO", "Inter", new DateTime(2024, 3, 21, 19, 23, 1, 586, DateTimeKind.Local).AddTicks(8427), 3, "www.google.com" },
                    { 4, "MERCK 1", "Inter", new DateTime(2024, 3, 21, 19, 23, 1, 586, DateTimeKind.Local).AddTicks(8429), 3, "www.google.com" },
                    { 5, "IDERT", "Inter", new DateTime(2024, 3, 21, 19, 23, 1, 586, DateTimeKind.Local).AddTicks(8431), 3, "www.google.com" },
                    { 6, "JUERTE", "Inter", new DateTime(2024, 3, 21, 19, 23, 1, 586, DateTimeKind.Local).AddTicks(8495), 3, "www.google.com" },
                    { 7, "CRECER", "Inter", new DateTime(2024, 3, 21, 19, 23, 1, 586, DateTimeKind.Local).AddTicks(8497), 3, "www.google.com" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 7);

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
    }
}
