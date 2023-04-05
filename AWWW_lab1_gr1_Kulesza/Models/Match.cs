using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AWWW_lab1_gr1_Kulesza.Models
{
    [Table("Matches")]
    public class Match
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string? Stadium { get; set; }
        // * - 0..1
        public virtual ICollection<Article>? Articles { get; set; }
        // 1 - *
        [Required]
        public virtual Team HomeTeam { get; set; } = null!;
        [Required]
        public int? HomeTeamId { get; set; }
        // 1 - *
        [Required]
        public virtual Team AwayTeam { get; set; } = null!;
        [Required]
        public int? AwayTeamId { get; set; }
        // * - 1
        public virtual ICollection<MatchPlayer>? MatchPlayers { get; set; }
        // * - 1
        public virtual ICollection<MatchEvent>? MatchEvents { get; set; }
    }
}
