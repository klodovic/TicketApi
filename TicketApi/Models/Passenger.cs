using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TicketApi.Models
{
    public class Passenger
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }

        [ForeignKey(nameof(CreditCard))]
        public int CreditCardId { get; set; }

        [ForeignKey(nameof(Report))]
        public int ReportId { get; set; }

        [ForeignKey(nameof(LoyaltyProgram))]
        public int LoyaltyProgramId { get; set; }

        [ForeignKey(nameof(LocalUser))]
        public int LocalUserId { get; set; }
    }
}
