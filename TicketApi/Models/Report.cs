using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TicketApi.Models
{
    public class Report
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string? UserReport { get; set; }

        [ForeignKey(nameof(LocalUser))]
        public int LocalUserId { get; set; }
    }
}
