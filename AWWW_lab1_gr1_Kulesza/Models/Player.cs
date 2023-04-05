using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AWWW_lab1_gr1_Kulesza.Models
{
    public class Player
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Country { get; set; }
        public DateTime? BirthDate { get; set; }
        // 1 - *
        [Required]
        public virtual Team Team { get; set; } = null!;
        [Required]
        public int TeamId { get; set; }
        //1 - *
        public virtual ICollection<Position>? Positions { get; set; }
        //* - 1
        public virtual ICollection<MatchPlayer>? MatchPlayers { get; set; }
    }
}
