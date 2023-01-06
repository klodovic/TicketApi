using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TicketApi.ModelsDTO
{
    public class CreatePassengerDTO
    {
        [Required]
        public DateTime DateOfBirth { get; set; }

        [Required]
        public int CreditCardId { get; set; }

        [Required]
        public int ReportId { get; set; }

        [Required]
        public int LoyaltyProgramId { get; set; }

        [ForeignKey(nameof(LocalUser))]
        public int LocalUserId { get; set; }
    }

        public class PassengerDTO : CreatePassengerDTO
    {
        public int Id { get; set; }
    }


}
