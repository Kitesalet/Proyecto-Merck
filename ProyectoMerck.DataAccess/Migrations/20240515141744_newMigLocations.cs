using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProyectoMerck.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class newMigLocations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAndtime",
                value: new DateTime(2024, 5, 15, 11, 17, 43, 484, DateTimeKind.Local).AddTicks(6118));

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateAndtime",
                value: new DateTime(2024, 5, 15, 11, 17, 43, 484, DateTimeKind.Local).AddTicks(6138));

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateAndtime",
                value: new DateTime(2024, 5, 15, 11, 17, 43, 484, DateTimeKind.Local).AddTicks(6139));

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateAndtime",
                value: new DateTime(2024, 5, 15, 11, 17, 43, 484, DateTimeKind.Local).AddTicks(6141));

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateAndtime",
                value: new DateTime(2024, 5, 15, 11, 17, 43, 484, DateTimeKind.Local).AddTicks(6143));

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateAndtime",
                value: new DateTime(2024, 5, 15, 11, 17, 43, 484, DateTimeKind.Local).AddTicks(6144));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1,
                column: "Subtitle",
                value: "Calle 1293");

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2,
                column: "Subtitle",
                value: "Calle 2983");

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3,
                column: "Subtitle",
                value: "Calle 3892");

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 4,
                column: "Subtitle",
                value: "Calle 2293");

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 5,
                column: "Subtitle",
                value: "Calle 3948");

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 6,
                column: "Subtitle",
                value: "Calle 4693");

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 7,
                column: "Subtitle",
                value: "Calle 3849");

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 8,
                column: "Subtitle",
                value: "Calle 8394");

            migrationBuilder.InsertData(
                table: "ProvinceLocations",
                columns: new[] { "Id", "Name", "ProvinceId" },
                values: new object[] { 5, "Todas", 1 });

            migrationBuilder.InsertData(
                table: "Provinces",
                columns: new[] { "Id", "CountryId", "Name" },
                values: new object[,]
                {
                    { 2, 2, "Córdoba" },
                    { 3, 2, "Santa Fe" },
                    { 4, 2, "Santa Cruz" }
                });

            migrationBuilder.InsertData(
                table: "ProvinceLocations",
                columns: new[] { "Id", "Name", "ProvinceId" },
                values: new object[,]
                {
                    { 6, "Ciudad de Córdoba", 2 },
                    { 7, "Rosario", 3 },
                    { 8, "Río Gallegos", 4 }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "Email", "Latitude", "Longitude", "ProvinceLocationId", "Subtitle", "Title" },
                values: new object[,]
                {
                    { 9, "mercktest111@gmail.com", -34.557128982074609, -58.447618128835863, 6, "Calle 3940", "Hospital Magenta" },
                    { 10, "mercktest111@gmail.com", -34.557128982074609, -58.447618128835863, 7, "Calle 3930", "Hospital Magenta" },
                    { 11, "mercktest111@gmail.com", -34.557128982074609, -58.447618128835863, 8, "Calle 2093", "Hospital Magenta" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ProvinceLocations",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ProvinceLocations",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ProvinceLocations",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ProvinceLocations",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAndtime",
                value: new DateTime(2024, 4, 29, 20, 9, 19, 280, DateTimeKind.Local).AddTicks(3264));

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateAndtime",
                value: new DateTime(2024, 4, 29, 20, 9, 19, 280, DateTimeKind.Local).AddTicks(3283));

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateAndtime",
                value: new DateTime(2024, 4, 29, 20, 9, 19, 280, DateTimeKind.Local).AddTicks(3285));

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateAndtime",
                value: new DateTime(2024, 4, 29, 20, 9, 19, 280, DateTimeKind.Local).AddTicks(3287));

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateAndtime",
                value: new DateTime(2024, 4, 29, 20, 9, 19, 280, DateTimeKind.Local).AddTicks(3288));

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateAndtime",
                value: new DateTime(2024, 4, 29, 20, 9, 19, 280, DateTimeKind.Local).AddTicks(3290));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1,
                column: "Subtitle",
                value: "Centro Fertilidad");

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2,
                column: "Subtitle",
                value: "Centro Fertilidad");

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3,
                column: "Subtitle",
                value: "Centro Fertilidad");

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 4,
                column: "Subtitle",
                value: "Centro Fertilidad");

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 5,
                column: "Subtitle",
                value: "Centro Fertilidad");

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 6,
                column: "Subtitle",
                value: "Centro Fertilidad");

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 7,
                column: "Subtitle",
                value: "Centro Fertilidad");

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 8,
                column: "Subtitle",
                value: "Centro Fertilidad");
        }
    }
}
