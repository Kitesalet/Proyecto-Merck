using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoMerck.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class dss : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAndtime",
                value: new DateTime(2024, 3, 21, 19, 23, 57, 510, DateTimeKind.Local).AddTicks(3594));

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateAndtime", "SelectedLocationIndex" },
                values: new object[] { new DateTime(2024, 3, 21, 19, 23, 57, 510, DateTimeKind.Local).AddTicks(3610), 4 });

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateAndtime", "SelectedLocationIndex" },
                values: new object[] { new DateTime(2024, 3, 21, 19, 23, 57, 510, DateTimeKind.Local).AddTicks(3611), 5 });

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateAndtime", "SelectedLocationIndex" },
                values: new object[] { new DateTime(2024, 3, 21, 19, 23, 57, 510, DateTimeKind.Local).AddTicks(3613), 6 });

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateAndtime", "SelectedLocationIndex" },
                values: new object[] { new DateTime(2024, 3, 21, 19, 23, 57, 510, DateTimeKind.Local).AddTicks(3657), 7 });

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateAndtime", "SelectedLocationIndex" },
                values: new object[] { new DateTime(2024, 3, 21, 19, 23, 57, 510, DateTimeKind.Local).AddTicks(3659), 8 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAndtime",
                value: new DateTime(2024, 3, 21, 19, 23, 1, 586, DateTimeKind.Local).AddTicks(8390));

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateAndtime", "SelectedLocationIndex" },
                values: new object[] { new DateTime(2024, 3, 21, 19, 23, 1, 586, DateTimeKind.Local).AddTicks(8427), 3 });

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateAndtime", "SelectedLocationIndex" },
                values: new object[] { new DateTime(2024, 3, 21, 19, 23, 1, 586, DateTimeKind.Local).AddTicks(8429), 3 });

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateAndtime", "SelectedLocationIndex" },
                values: new object[] { new DateTime(2024, 3, 21, 19, 23, 1, 586, DateTimeKind.Local).AddTicks(8431), 3 });

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateAndtime", "SelectedLocationIndex" },
                values: new object[] { new DateTime(2024, 3, 21, 19, 23, 1, 586, DateTimeKind.Local).AddTicks(8495), 3 });

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateAndtime", "SelectedLocationIndex" },
                values: new object[] { new DateTime(2024, 3, 21, 19, 23, 1, 586, DateTimeKind.Local).AddTicks(8497), 3 });
        }
    }
}
