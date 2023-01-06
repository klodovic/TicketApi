using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TicketApi.Models
{
    public class LoyaltyProgram
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public bool Student { get; set; }
        [Required]
        public bool Pensioner { get; set; }
        [Required]
        public bool LoyaltyMember { get; set; }

    }
}
