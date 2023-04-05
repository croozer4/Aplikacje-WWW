using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AWWW_lab1_gr1_Kulesza.Models
{
    [Table("MatchEvents")]
    public class MatchEvent
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int Minute { get; set; }
        // 1 - *
        [Required]
        public virtual Match Match { get; set; } = null!;
        [Required]
        public int MatchId { get; set; }
        // 0..1 - *
        public virtual MatchPlayer? MatchPlayer { get; set; }
        public int? MatchPlayerId { get; set; }
        // 1 - *
        [Required]
        public virtual EventType EventType { get; set; } = null!;
        [Required]
        public int EventTypeId { get; set; }
    }
}
