using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TicketApi.ModelsDTO
{
    public class CreateReportDTO
    {
        [Required]
        public string? UserReport { get; set; }

        [ForeignKey(nameof(LocalUser))]
        public int LocalUserId { get; set; }
    }

    public class ReportDTO : CreateReportDTO
    {
        public int Id { get; set; }
    }
}
