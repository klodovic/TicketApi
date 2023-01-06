using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TicketApi.Models
{
    public class Line
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string? LineName { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal TicketPrice { get; set; }

        [ForeignKey(nameof(Train))]
        public int TrainId { get; set; }

        [ForeignKey(nameof(Carrier))]
        public int CarrierId { get; set; }
    }
}
