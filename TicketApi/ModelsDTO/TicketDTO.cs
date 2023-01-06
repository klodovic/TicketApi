
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TicketApi.ModelsDTO
{
    public class CreateTicketDTO
    {
        [Required]
        [StringLength(maximumLength: 50, ErrorMessage = "Max lenght is 50 character only ")]
        public string? TicketNumber { get; set; }

        [Required]
        //[Precision(18, 2)]
        public decimal TotalTicketPrice { get; set; }

        [Required]
        public int PassengerId { get; set; }

        [Required]
        public int LineId { get; set; }
    }

    public class TicketDTO : CreateTicketDTO
    {
        public int Id { get; set; }
    }
}
