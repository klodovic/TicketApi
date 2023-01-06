using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TicketApi.Migrations
{
    /// <inheritdoc />
    public partial class updateLocalUserTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateTime(1983, 1, 3, 17, 12, 42, 59, DateTimeKind.Local).AddTicks(1344));

            migrationBuilder.UpdateData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfBirth",
                value: new DateTime(1967, 1, 3, 17, 12, 42, 59, DateTimeKind.Local).AddTicks(1350));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 1, 3, 20, 12, 42, 59, DateTimeKind.Local).AddTicks(1134), new DateTime(2023, 1, 3, 17, 12, 42, 59, DateTimeKind.Local).AddTicks(1100) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 1, 3, 17, 12, 42, 59, DateTimeKind.Local).AddTicks(1140), new DateTime(2023, 1, 2, 17, 12, 42, 59, DateTimeKind.Local).AddTicks(1137) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 1, 3, 9, 12, 42, 59, DateTimeKind.Local).AddTicks(1143), new DateTime(2023, 1, 3, 7, 12, 42, 59, DateTimeKind.Local).AddTicks(1140) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateTime(1983, 1, 3, 17, 5, 4, 511, DateTimeKind.Local).AddTicks(419));

            migrationBuilder.UpdateData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfBirth",
                value: new DateTime(1967, 1, 3, 17, 5, 4, 511, DateTimeKind.Local).AddTicks(425));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 1, 3, 20, 5, 4, 511, DateTimeKind.Local).AddTicks(166), new DateTime(2023, 1, 3, 17, 5, 4, 511, DateTimeKind.Local).AddTicks(129) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 1, 3, 17, 5, 4, 511, DateTimeKind.Local).AddTicks(172), new DateTime(2023, 1, 2, 17, 5, 4, 511, DateTimeKind.Local).AddTicks(169) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 1, 3, 9, 5, 4, 511, DateTimeKind.Local).AddTicks(175), new DateTime(2023, 1, 3, 7, 5, 4, 511, DateTimeKind.Local).AddTicks(172) });
        }
    }
}
