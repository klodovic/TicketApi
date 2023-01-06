using Microsoft.EntityFrameworkCore;

namespace TicketApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Schedule>().HasData(
                    new Schedule
                    {
                        Id = 1,
                        Departure = DateTime.Now,
                        Arrival = DateTime.Now.AddHours(3),
                    },
                    new Schedule
                    {
                        Id = 2,
                        Departure = DateTime.Now.AddDays(-1),
                        Arrival = DateTime.Now,
                    },
                    new Schedule
                    {
                        Id = 3,
                        Departure = DateTime.Now.AddHours(-10),
                        Arrival = DateTime.Now.AddHours(-8),
                    }
                );

            modelBuilder.Entity<Town>().HasData(
                    new Town
                    {
                        Id = 1,
                        Destination = "Zagreb",
                        StartingLocation = "Split",
                        ScheduleId = 1
                    },
                    new Town
                    {
                        Id = 2,
                        Destination = "Rijeka",
                        StartingLocation = "Vinkovci",
                        ScheduleId = 2
                    }
                );

            modelBuilder.Entity<Train>().HasData(
                    new Train
                    {
                        Id = 1,
                        TrainNumber = "TRW12",
                        TrainName = "Ubrzani",
                        TrainType = "Putnicki",
                        Class = "2",
                        TownId = 2
                    },
                    new Train
                    {
                        Id = 2,
                        TrainNumber = "56HZ",
                        TrainName = "Brzi",
                        TrainType = "Putnicki",
                        Class = "1",
                        TownId = 1
                    }
                );

            modelBuilder.Entity<Line>().HasData(
                    new Line
                    {
                        Id = 1,
                        LineName = "Zagreb-Split",
                        TicketPrice = 100,
                        TrainId = 1,
                        CarrierId = 1,
                    },
                    new Line
                    {
                        Id = 2,
                        LineName = "Rijeka-Vinkovci",
                        TicketPrice = 200,
                        TrainId = 2,
                        CarrierId = 2,
                    }
                );

            modelBuilder.Entity<Ticket>().HasData(
                    new Ticket
                    {
                        Id = 1,
                        TicketNumber = "#123TB56",
                        TotalTicketPrice = 120,
                        PassengerId = 1,
                        LineId = 1,
                    },
                    new Ticket
                    {
                        Id = 2,
                        TicketNumber = "#123TB56",
                        TotalTicketPrice = 240,
                        PassengerId = 2,
                        LineId = 2,
                    }
                );

            modelBuilder.Entity<Carrier>().HasData(
                    new Carrier
                    {
                        Id = 1,
                        CarrierName = "LOG RAIL d.o.o.",
                        LocalUserId = 3,
                        ReportId = 1,
                    },
                    new Carrier
                    {
                        Id = 2,
                        CarrierName = "ADRIA TRANSPORT CROATIA d.o.o.",
                        LocalUserId= 3,
                        ReportId = 2,
                    }
                );

            modelBuilder.Entity<Report>().HasData(
                    new Report
                    {
                        Id = 1,
                        UserReport = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                        LocalUserId = 3
                    },
                    new Report
                    {
                        Id = 2,
                        UserReport = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s.",
                        LocalUserId = 1
                    }
                );

            modelBuilder.Entity<Passenger>().HasData(
                    new Passenger
                    {
                        Id = 1,
                        DateOfBirth = DateTime.Now.AddYears(-40),
                        CreditCardId = 1,
                        ReportId = 1,
                        LoyaltyProgramId = 1,
                        LocalUserId = 1
                    },
                    new Passenger
                    {
                        Id = 2,
                        DateOfBirth = DateTime.Now.AddYears(-56),
                        CreditCardId = 2,
                        ReportId = 2,
                        LoyaltyProgramId = 2,
                        LocalUserId = 2
                    }
                );

            modelBuilder.Entity<LoyaltyProgram>().HasData(
                    new LoyaltyProgram
                    {
                        Id = 1,
                        Student = true,
                        Pensioner = false,
                        LoyaltyMember = false
                    },
                    new LoyaltyProgram
                    {
                        Id = 2,
                        Student = false,
                        Pensioner = true,
                        LoyaltyMember = true
                    }
                );

            modelBuilder.Entity<CreditCard>().HasData(
                    new CreditCard
                    {
                        Id = 1,
                        CreditCardType = "Visa",
                        CreditCardNumber = "6548RET",
                        ValidThru = "05/24",
                        AuthorizedSignature = "701"
                    },
                    new CreditCard
                    {
                        Id = 2,
                        CreditCardType = "MasterCard",
                        CreditCardNumber = "ETP897114",
                        ValidThru = "08/25",
                        AuthorizedSignature = "104"
                    }
                );
        }

        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<Town> Towns { get; set; }
        public DbSet<Train> Trains { get; set; }
        public DbSet<Line> Lines { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Carrier> Carriers { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<Passenger> Passengers { get; set; }
        public DbSet<CreditCard> CreditCards { get; set; }
        public DbSet<LoyaltyProgram> LoyaltyPrograms { get; set; }
        public DbSet<LocalUser> LocalUsers { get; set; }
    }
}
