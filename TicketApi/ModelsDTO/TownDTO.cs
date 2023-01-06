using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TicketApi.ModelsDTO
{
    public class CreateTownDTO
    {
        [Required]
        [StringLength(maximumLength: 50, ErrorMessage = "Max lenght is 50 character only ")]
        public string? StartingLocation { get; set; }

        [Required]
        [StringLength(maximumLength: 50, ErrorMessage = "Max lenght is 50 character only ")]
        public string? Destination { get; set; }

        [Required]
        public int ScheduleId { get; set; }
    }

    public class TownDTO : CreateTownDTO
    {
        public int Id { get; set; }
        //public ScheduleDTO Schedule { get; set; }
    }
}
