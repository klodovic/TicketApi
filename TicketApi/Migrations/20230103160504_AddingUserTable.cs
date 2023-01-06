using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TicketApi.Migrations
{
    /// <inheritdoc />
    public partial class AddingUserTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LocalUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(20)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocalUsers", x => x.Id);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LocalUsers");

            migrationBuilder.UpdateData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateTime(1983, 1, 1, 17, 47, 41, 809, DateTimeKind.Local).AddTicks(7674));

            migrationBuilder.UpdateData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfBirth",
                value: new DateTime(1967, 1, 1, 17, 47, 41, 809, DateTimeKind.Local).AddTicks(7680));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 1, 1, 20, 47, 41, 809, DateTimeKind.Local).AddTicks(7423), new DateTime(2023, 1, 1, 17, 47, 41, 809, DateTimeKind.Local).AddTicks(7380) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 1, 1, 17, 47, 41, 809, DateTimeKind.Local).AddTicks(7429), new DateTime(2022, 12, 31, 17, 47, 41, 809, DateTimeKind.Local).AddTicks(7426) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 1, 1, 9, 47, 41, 809, DateTimeKind.Local).AddTicks(7433), new DateTime(2023, 1, 1, 7, 47, 41, 809, DateTimeKind.Local).AddTicks(7429) });
        }
    }
}
