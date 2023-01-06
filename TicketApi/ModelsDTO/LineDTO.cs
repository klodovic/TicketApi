
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace TicketApi.ModelsDTO
{
    public class CreateLineDTO
    {
        [Required]
        [StringLength(maximumLength: 50, ErrorMessage = "Max lenght is 50 character only ")]
        public string? LineName { get; set; }

        [Required]
        //[Precision(18, 2)]
        public decimal TicketPrice { get; set; }

        [Required]
        public int TrainId { get; set; }

        [Required]
        public int CarrierId { get; set; }
    }

    public class LineDTO : CreateLineDTO
    {
        public int Id { get; set; }

    }
}
