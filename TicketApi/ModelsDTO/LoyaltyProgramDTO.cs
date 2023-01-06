using System.ComponentModel.DataAnnotations;

namespace TicketApi.ModelsDTO
{
    public class CreateLoyaltyProgramDTO
    {
        [Required]
        public bool Student { get; set; }

        [Required]
        public bool Pensioner { get; set; }

        [Required]
        public bool LoyaltyMember { get; set; }
    }

        public class LoyaltyProgramDTO : CreateLoyaltyProgramDTO
    {
        public int Id { get; set; }
    }


}
