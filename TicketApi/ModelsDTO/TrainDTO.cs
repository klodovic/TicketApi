using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TicketApi.ModelsDTO
{
    public class CreateTrainDTO
    {
        [Required]
        [StringLength(maximumLength: 50, ErrorMessage = "Max lenght is 50 character only ")]
        public string? TrainNumber { get; set; }

        [Required]
        [StringLength(maximumLength: 50, ErrorMessage = "Max lenght is 50 character only ")]
        public string? TrainName { get; set; }

        [Required]
        [StringLength(maximumLength: 50, ErrorMessage = "Max lenght is 50 character only ")]
        public string? TrainType { get; set; }

        [Required]
        [StringLength(maximumLength: 50, ErrorMessage = "Max lenght is 50 character only ")]
        public string? Class { get; set; }

        [Required] 
        public int TownId { get; set; }

    }

    public class TrainDTO : CreateTrainDTO
    {
        public int Id { get; set; }
        //public TownDTO Town { get; set; }
    }
}
