﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TicketApi.Data;

#nullable disable

namespace TicketApi.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230104165050_UpdateThreeDatabaseTables")]
    partial class UpdateThreeDatabaseTables
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TicketApi.Models.Carrier", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CarrierName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LocalUserId")
                        .HasColumnType("int");

                    b.Property<int>("ReportId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Carriers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CarrierName = "LOG RAIL d.o.o.",
                            LocalUserId = 3,
                            ReportId = 1
                        },
                        new
                        {
                            Id = 2,
                            CarrierName = "ADRIA TRANSPORT CROATIA d.o.o.",
                            LocalUserId = 3,
                            ReportId = 2
                        });
                });

            modelBuilder.Entity("TicketApi.Models.CreditCard", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AuthorizedSignature")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreditCardNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreditCardType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ValidThru")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CreditCards");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AuthorizedSignature = "701",
                            CreditCardNumber = "6548RET",
                            CreditCardType = "Visa",
                            ValidThru = "05/24"
                        },
                        new
                        {
                            Id = 2,
                            AuthorizedSignature = "104",
                            CreditCardNumber = "ETP897114",
                            CreditCardType = "MasterCard",
                            ValidThru = "08/25"
                        });
                });

            modelBuilder.Entity("TicketApi.Models.Line", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CarrierId")
                        .HasColumnType("int");

                    b.Property<string>("LineName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("TicketPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("TrainId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Lines");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CarrierId = 1,
                            LineName = "Zagreb-Split",
                            TicketPrice = 100m,
                            TrainId = 1
                        },
                        new
                        {
                            Id = 2,
                            CarrierId = 2,
                            LineName = "Rijeka-Vinkovci",
                            TicketPrice = 200m,
                            TrainId = 2
                        });
                });

            modelBuilder.Entity("TicketApi.Models.LocalUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("LocalUsers");
                });

            modelBuilder.Entity("TicketApi.Models.LoyaltyProgram", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("LoyaltyMember")
                        .HasColumnType("bit");

                    b.Property<bool>("Pensioner")
                        .HasColumnType("bit");

                    b.Property<bool>("Student")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("LoyaltyPrograms");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            LoyaltyMember = false,
                            Pensioner = false,
                            Student = true
                        },
                        new
                        {
                            Id = 2,
                            LoyaltyMember = true,
                            Pensioner = true,
                            Student = false
                        });
                });

            modelBuilder.Entity("TicketApi.Models.Passenger", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CreditCardId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<int>("LocalUserId")
                        .HasColumnType("int");

                    b.Property<int>("LoyaltyProgramId")
                        .HasColumnType("int");

                    b.Property<int>("ReportId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Passengers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreditCardId = 1,
                            DateOfBirth = new DateTime(1983, 1, 4, 17, 50, 50, 232, DateTimeKind.Local).AddTicks(1885),
                            LocalUserId = 1,
                            LoyaltyProgramId = 1,
                            ReportId = 1
                        },
                        new
                        {
                            Id = 2,
                            CreditCardId = 2,
                            DateOfBirth = new DateTime(1967, 1, 4, 17, 50, 50, 232, DateTimeKind.Local).AddTicks(1892),
                            LocalUserId = 2,
                            LoyaltyProgramId = 2,
                            ReportId = 2
                        });
                });

            modelBuilder.Entity("TicketApi.Models.Report", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("LocalUserId")
                        .HasColumnType("int");

                    b.Property<string>("UserReport")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Reports");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            LocalUserId = 3,
                            UserReport = "Lorem Ipsum is simply dummy text of the printing and typesetting industry."
                        },
                        new
                        {
                            Id = 2,
                            LocalUserId = 1,
                            UserReport = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s."
                        });
                });

            modelBuilder.Entity("TicketApi.Models.Schedule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Arrival")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Departure")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Schedules");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Arrival = new DateTime(2023, 1, 4, 20, 50, 50, 232, DateTimeKind.Local).AddTicks(1626),
                            Departure = new DateTime(2023, 1, 4, 17, 50, 50, 232, DateTimeKind.Local).AddTicks(1573)
                        },
                        new
                        {
                            Id = 2,
                            Arrival = new DateTime(2023, 1, 4, 17, 50, 50, 232, DateTimeKind.Local).AddTicks(1632),
                            Departure = new DateTime(2023, 1, 3, 17, 50, 50, 232, DateTimeKind.Local).AddTicks(1629)
                        },
                        new
                        {
                            Id = 3,
                            Arrival = new DateTime(2023, 1, 4, 9, 50, 50, 232, DateTimeKind.Local).AddTicks(1635),
                            Departure = new DateTime(2023, 1, 4, 7, 50, 50, 232, DateTimeKind.Local).AddTicks(1632)
                        });
                });

            modelBuilder.Entity("TicketApi.Models.Ticket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("LineId")
                        .HasColumnType("int");

                    b.Property<int>("PassengerId")
                        .HasColumnType("int");

                    b.Property<string>("TicketNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("TotalTicketPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Tickets");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            LineId = 1,
                            PassengerId = 1,
                            TicketNumber = "#123TB56",
                            TotalTicketPrice = 120m
                        },
                        new
                        {
                            Id = 2,
                            LineId = 2,
                            PassengerId = 2,
                            TicketNumber = "#123TB56",
                            TotalTicketPrice = 240m
                        });
                });

            modelBuilder.Entity("TicketApi.Models.Town", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Destination")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ScheduleId")
                        .HasColumnType("int");

                    b.Property<string>("StartingLocation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Towns");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Destination = "Zagreb",
                            ScheduleId = 1,
                            StartingLocation = "Split"
                        },
                        new
                        {
                            Id = 2,
                            Destination = "Rijeka",
                            ScheduleId = 2,
                            StartingLocation = "Vinkovci"
                        });
                });

            modelBuilder.Entity("TicketApi.Models.Train", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Class")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TownId")
                        .HasColumnType("int");

                    b.Property<string>("TrainName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TrainNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TrainType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Trains");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Class = "2",
                            TownId = 2,
                            TrainName = "Ubrzani",
                            TrainNumber = "TRW12",
                            TrainType = "Putnicki"
                        },
                        new
                        {
                            Id = 2,
                            Class = "1",
                            TownId = 1,
                            TrainName = "Brzi",
                            TrainNumber = "56HZ",
                            TrainType = "Putnicki"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
