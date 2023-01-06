using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TicketApi.Models
{
    public class Train
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string? TrainNumber { get; set; }

        [Required]
        public string? TrainName { get; set; }

        [Required]
        public string? TrainType { get; set; }

        [Required]
        public string? Class { get; set; }

        [ForeignKey(nameof(Town))]
        public int TownId { get; set; }
        //public Town Town { get; set; }
    }
}
