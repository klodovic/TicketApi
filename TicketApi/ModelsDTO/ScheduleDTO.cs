using System.ComponentModel.DataAnnotations;

namespace TicketApi.ModelsDTO
{
    public class CreateSchedulesDTO
    {

        [Required]
        public DateTime Departure { get; set; }

        [Required]
        //[StringLength(50, ErrorMessage = "Max character is 50...")]
        public DateTime Arrival { get; set; }
    }

    public class ScheduleDTO : CreateSchedulesDTO
    {
        public int Id { get; set; }
    }


}
