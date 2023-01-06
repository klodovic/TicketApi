using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TicketApi.Models
{
    public class Carrier
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string? CarrierName { get; set; }


        [ForeignKey(nameof(LocalUser))]
        public int LocalUserId { get; set; }


        [ForeignKey(nameof(Report))]
        public int ReportId { get; set; }
    }
}
