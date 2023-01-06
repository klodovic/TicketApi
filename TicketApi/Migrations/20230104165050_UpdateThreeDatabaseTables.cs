using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TicketApi.Migrations
{
    /// <inheritdoc />
    public partial class UpdateThreeDatabaseTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LocalUserId",
                table: "Reports",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LocalUserId",
                table: "Passengers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LocalUserId",
                table: "Carriers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Carriers",
                keyColumn: "Id",
                keyValue: 1,
                column: "LocalUserId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Carriers",
                keyColumn: "Id",
                keyValue: 2,
                column: "LocalUserId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateOfBirth", "LocalUserId" },
                values: new object[] { new DateTime(1983, 1, 4, 17, 50, 50, 232, DateTimeKind.Local).AddTicks(1885), 1 });

            migrationBuilder.UpdateData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateOfBirth", "LocalUserId" },
                values: new object[] { new DateTime(1967, 1, 4, 17, 50, 50, 232, DateTimeKind.Local).AddTicks(1892), 2 });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1,
                column: "LocalUserId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 2,
                column: "LocalUserId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 1, 4, 20, 50, 50, 232, DateTimeKind.Local).AddTicks(1626), new DateTime(2023, 1, 4, 17, 50, 50, 232, DateTimeKind.Local).AddTicks(1573) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 1, 4, 17, 50, 50, 232, DateTimeKind.Local).AddTicks(1632), new DateTime(2023, 1, 3, 17, 50, 50, 232, DateTimeKind.Local).AddTicks(1629) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 1, 4, 9, 50, 50, 232, DateTimeKind.Local).AddTicks(1635), new DateTime(2023, 1, 4, 7, 50, 50, 232, DateTimeKind.Local).AddTicks(1632) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LocalUserId",
                table: "Reports");

            migrationBuilder.DropColumn(
                name: "LocalUserId",
                table: "Passengers");

            migrationBuilder.DropColumn(
                name: "LocalUserId",
                table: "Carriers");

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
    }
}
