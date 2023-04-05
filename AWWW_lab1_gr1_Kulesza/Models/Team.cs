using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AWWW_lab1_gr1_Kulesza.Models
{
    [Table("Teams")]
    public class Team
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Country { get; set; }
        public string? City { get; set; }
        public DateTime FoundingDate { get; set; }
        // * - 2
        //public ICollection<Match>? Matches { get; set; }
        // 1 - *
        [Required]
        public virtual League? League { get; set; } = null!;
        [Required]
        public int? LeagueId { get; set; }
        //* - 1
        public virtual ICollection<Player>? Players { get; set; }
    
        public virtual ICollection<Match>? HomeMatches { get; set; }
        public virtual ICollection<Match>? AwayMatches { get; set; }
    }
}
