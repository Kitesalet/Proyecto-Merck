using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

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

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "Email", "Latitude", "Longitude", "ProvinceLocationId", "Subtitle", "Title" },
                values: new object[] { 2, "mercktest111@gmail.com", -34.580702852634481, -58.430260973627661, 1, "Centro Fertilidad", "Clínica Azul" });

            migrationBuilder.InsertData(
                table: "ProvinceLocations",
                columns: new[] { "Id", "Name", "ProvinceId" },
                values: new object[,]
                {
                    { 2, "Recoleta", 1 },
                    { 3, "Caballito", 1 },
                    { 4, "Belgrano", 1 }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "Email", "Latitude", "Longitude", "ProvinceLocationId", "Subtitle", "Title" },
                values: new object[,]
                {
                    { 3, "mercktest111@gmail.com", -34.578846588221204, -58.460103931977983, 2, "Centro Fertilidad", "Clínica Violeta" },
                    { 4, "mercktest111@gmail.com", -34.599254733727243, -58.401810339490027, 2, "Centro Fertilidad", "Clínica Verde" },
                    { 5, "mercktest111@gmail.com", -34.597439056459208, -58.397189279473473, 3, "Centro Fertilidad", "Clínica Amarilla" },
                    { 6, "mercktest111@gmail.com", -34.606202223417398, -58.425645264604945, 3, "Centro Fertilidad", "Hospital Rojo" },
                    { 7, "mercktest111@gmail.com", -34.596689236707874, -58.399734815343471, 4, "Centro Fertilidad", "Hospital Fucsia" },
                    { 8, "mercktest111@gmail.com", -34.557128982074609, -58.447618128835863, 4, "Centro Fertilidad", "Hospital Magenta" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ProvinceLocations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProvinceLocations",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProvinceLocations",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAndtime",
                value: new DateTime(2024, 4, 29, 20, 7, 44, 412, DateTimeKind.Local).AddTicks(9110));

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateAndtime",
                value: new DateTime(2024, 4, 29, 20, 7, 44, 412, DateTimeKind.Local).AddTicks(9128));

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateAndtime",
                value: new DateTime(2024, 4, 29, 20, 7, 44, 412, DateTimeKind.Local).AddTicks(9129));

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateAndtime",
                value: new DateTime(2024, 4, 29, 20, 7, 44, 412, DateTimeKind.Local).AddTicks(9131));

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateAndtime",
                value: new DateTime(2024, 4, 29, 20, 7, 44, 412, DateTimeKind.Local).AddTicks(9132));

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateAndtime",
                value: new DateTime(2024, 4, 29, 20, 7, 44, 412, DateTimeKind.Local).AddTicks(9134));
        }
    }
}
