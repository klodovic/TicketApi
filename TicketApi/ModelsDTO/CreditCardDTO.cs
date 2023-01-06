using System.ComponentModel.DataAnnotations;

namespace TicketApi.ModelsDTO
{
    public class CreateCreditCardDTO
    {
        [Required]
        [StringLength(maximumLength: 50, ErrorMessage = "Max lenght is 50 character only ")]
        public string? CreditCardType { get; set; }

        [Required]
        [StringLength(maximumLength: 50, ErrorMessage = "Max lenght is 50 character only ")]
        public string? CreditCardNumber { get; set; }

        [Required]
        [StringLength(maximumLength: 50, ErrorMessage = "Max lenght is 50 character only ")]
        public string? ValidThru { get; set; }

        [Required]
        [StringLength(maximumLength: 50, ErrorMessage = "Max lenght is 50 character only ")]
        public string? AuthorizedSignature { get; set; }
    }

        public class CreditCardDTO : CreateCreditCardDTO
    {
        public int Id { get; set; }
    }


}
