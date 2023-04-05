using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AWWW_lab1_gr1_Kulesza.Models
{
    [Table("Positions")]
    public class Position
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? Name { get; set; }
        // * - 1
        public virtual ICollection<MatchPlayer>? MatchPlayers { get; set; }
        // * - 1
        public virtual ICollection<Player>? Players { get; set; }
    
        public Position(string name)
        {
            Name = name;
        }
    }
}
