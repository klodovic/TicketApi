using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TicketApi.Migrations
{
    /// <inheritdoc />
    public partial class CreateDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Carriers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarrierName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReportId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carriers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CreditCards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreditCardType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreditCardNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ValidThru = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AuthorizedSignature = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreditCards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Lines",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LineName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TicketPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TrainId = table.Column<int>(type: "int", nullable: false),
                    CarrierId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lines", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LoyaltyPrograms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Student = table.Column<bool>(type: "bit", nullable: false),
                    Pensioner = table.Column<bool>(type: "bit", nullable: false),
                    LoyaltyMember = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoyaltyPrograms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Passengers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreditCardId = table.Column<int>(type: "int", nullable: false),
                    ReportId = table.Column<int>(type: "int", nullable: false),
                    LoyaltyProgramId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Passengers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Reports",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserReport = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reports", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Schedules",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Departure = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Arrival = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schedules", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TicketNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TotalTicketPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PassengerId = table.Column<int>(type: "int", nullable: false),
                    LineId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Towns",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartingLocation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Destination = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ScheduleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Towns", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Trains",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TrainNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrainName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrainType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Class = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TownId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trains", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Carriers",
                columns: new[] { "Id", "CarrierName", "ReportId" },
                values: new object[,]
                {
                    { 1, "LOG RAIL d.o.o.", 1 },
                    { 2, "ADRIA TRANSPORT CROATIA d.o.o.", 2 }
                });

            migrationBuilder.InsertData(
                table: "CreditCards",
                columns: new[] { "Id", "AuthorizedSignature", "CreditCardNumber", "CreditCardType", "ValidThru" },
                values: new object[,]
                {
                    { 1, "701", "6548RET", "Visa", "05/24" },
                    { 2, "104", "ETP897114", "MasterCard", "08/25" }
                });

            migrationBuilder.InsertData(
                table: "Lines",
                columns: new[] { "Id", "CarrierId", "LineName", "TicketPrice", "TrainId" },
                values: new object[,]
                {
                    { 1, 1, "Zagreb-Split", 100m, 1 },
                    { 2, 2, "Rijeka-Vinkovci", 200m, 2 }
                });

            migrationBuilder.InsertData(
                table: "LoyaltyPrograms",
                columns: new[] { "Id", "LoyaltyMember", "Pensioner", "Student" },
                values: new object[,]
                {
                    { 1, false, false, true },
                    { 2, true, true, false }
                });

            migrationBuilder.InsertData(
                table: "Passengers",
                columns: new[] { "Id", "CreditCardId", "DateOfBirth", "LoyaltyProgramId", "ReportId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(1983, 1, 1, 17, 47, 41, 809, DateTimeKind.Local).AddTicks(7674), 1, 1 },
                    { 2, 2, new DateTime(1967, 1, 1, 17, 47, 41, 809, DateTimeKind.Local).AddTicks(7680), 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "Reports",
                columns: new[] { "Id", "UserReport" },
                values: new object[,]
                {
                    { 1, "Lorem Ipsum is simply dummy text of the printing and typesetting industry." },
                    { 2, "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s." }
                });

            migrationBuilder.InsertData(
                table: "Schedules",
                columns: new[] { "Id", "Arrival", "Departure" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 1, 1, 20, 47, 41, 809, DateTimeKind.Local).AddTicks(7423), new DateTime(2023, 1, 1, 17, 47, 41, 809, DateTimeKind.Local).AddTicks(7380) },
                    { 2, new DateTime(2023, 1, 1, 17, 47, 41, 809, DateTimeKind.Local).AddTicks(7429), new DateTime(2022, 12, 31, 17, 47, 41, 809, DateTimeKind.Local).AddTicks(7426) },
                    { 3, new DateTime(2023, 1, 1, 9, 47, 41, 809, DateTimeKind.Local).AddTicks(7433), new DateTime(2023, 1, 1, 7, 47, 41, 809, DateTimeKind.Local).AddTicks(7429) }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "LineId", "PassengerId", "TicketNumber", "TotalTicketPrice" },
                values: new object[,]
                {
                    { 1, 1, 1, "#123TB56", 120m },
                    { 2, 2, 2, "#123TB56", 240m }
                });

            migrationBuilder.InsertData(
                table: "Towns",
                columns: new[] { "Id", "Destination", "ScheduleId", "StartingLocation" },
                values: new object[,]
                {
                    { 1, "Zagreb", 1, "Split" },
                    { 2, "Rijeka", 2, "Vinkovci" }
                });

            migrationBuilder.InsertData(
                table: "Trains",
                columns: new[] { "Id", "Class", "TownId", "TrainName", "TrainNumber", "TrainType" },
                values: new object[,]
                {
                    { 1, "2", 2, "Ubrzani", "TRW12", "Putnicki" },
                    { 2, "1", 1, "Brzi", "56HZ", "Putnicki" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Carriers");

            migrationBuilder.DropTable(
                name: "CreditCards");

            migrationBuilder.DropTable(
                name: "Lines");

            migrationBuilder.DropTable(
                name: "LoyaltyPrograms");

            migrationBuilder.DropTable(
                name: "Passengers");

            migrationBuilder.DropTable(
                name: "Reports");

            migrationBuilder.DropTable(
                name: "Schedules");

            migrationBuilder.DropTable(
                name: "Tickets");

            migrationBuilder.DropTable(
                name: "Towns");

            migrationBuilder.DropTable(
                name: "Trains");
        }
    }
}
