using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TicketApi.Models
{
    public class CreditCard
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string? CreditCardType { get; set; }

        [Required]
        public string? CreditCardNumber { get; set; }

        [Required]
        public string? ValidThru { get; set; }

        [Required]
        public string? AuthorizedSignature { get; set; }
    }
}
