using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TicketApi.Models
{
    public class Town
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string? StartingLocation { get; set; }

        [Required]
        public string? Destination { get; set; }

        [ForeignKey(nameof(Schedule))]
        public int ScheduleId { get; set;}
        //public Schedule Schedule { get; set; }
    }
}
