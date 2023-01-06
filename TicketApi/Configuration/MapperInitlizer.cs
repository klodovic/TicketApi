using AutoMapper;

namespace TicketApi.Configuration
{
    public class MapperInitlizer : Profile
    {
        public MapperInitlizer()
        {
            CreateMap<Schedule, ScheduleDTO>().ReverseMap();
            CreateMap<Schedule, CreateSchedulesDTO>().ReverseMap();

            CreateMap<Town, TownDTO>().ReverseMap();
            CreateMap<Town, CreateTownDTO>().ReverseMap();

            CreateMap<Train, TrainDTO>().ReverseMap();
            CreateMap<Train, CreateTrainDTO>().ReverseMap();

            CreateMap<Line, LineDTO>().ReverseMap();
            CreateMap<Line, CreateLineDTO>().ReverseMap();

            CreateMap<Ticket, TicketDTO>().ReverseMap();
            CreateMap<Ticket, CreateTicketDTO>().ReverseMap();

            CreateMap<Report, ReportDTO>().ReverseMap();
            CreateMap<Report, CreateReportDTO>().ReverseMap();

            CreateMap<Carrier, CarrierDTO>().ReverseMap();
            CreateMap<Carrier, CreateCarrierDTO>().ReverseMap();

            CreateMap<Passenger, PassengerDTO>().ReverseMap();
            CreateMap<Passenger, CreatePassengerDTO>().ReverseMap();

            CreateMap<CreditCard, CreditCardDTO>().ReverseMap();
            CreateMap<CreditCard, CreateCreditCardDTO>().ReverseMap();

            CreateMap<LoyaltyProgram, LoyaltyProgramDTO>().ReverseMap();
            CreateMap<LoyaltyProgram, CreateLoyaltyProgramDTO>().ReverseMap();
        }
    }
}
