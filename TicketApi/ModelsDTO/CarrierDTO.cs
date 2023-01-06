using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TicketApi.ModelsDTO
{
    public class CreateCarrierDTO
    {
        [Required]
        [StringLength(maximumLength: 50, ErrorMessage = "Max lenght is 50 character only ")]
        public string? CarrierName { get; set; }

        [ForeignKey(nameof(LocalUser))]
        public int LocalUserId { get; set; }

        [Required]
        public int ReportId { get; set; }
    }

    public class CarrierDTO : CreateCarrierDTO
    {
        public int Id { get; set; }
    }
}
