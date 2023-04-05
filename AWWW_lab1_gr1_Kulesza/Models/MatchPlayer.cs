using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AWWW_lab1_gr1_Kulesza.Models
{
    [Table("MatchPlayers")]
    public class MatchPlayer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        // 1 - *
        [Required]
        public virtual Match Match { get; set; } = null!;
        [Required]
        public int MatchId { get; set; }
        // 1 - *
        [Required]
        public virtual Position Position { get; set; } = null!;
        [Required]
        public int? PositionId { get; set; }
        // 1 - *
        [Required]
        public virtual Player Player { get; set; } = null!;
        [Required]
        public int PlayerId { get; set; }
        // * - 0..1
        public virtual ICollection<MatchEvent>? MatchEvents { get; set; }
    }
}
