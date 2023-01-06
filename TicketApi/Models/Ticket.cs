using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TicketApi.Models
{
    public class Ticket
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string? TicketNumber { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalTicketPrice { get; set; }

        [ForeignKey(nameof(Passenger))]
        public int PassengerId { get; set; }

        [ForeignKey(nameof(Line))]
        public int LineId { get; set; }
    }
}
