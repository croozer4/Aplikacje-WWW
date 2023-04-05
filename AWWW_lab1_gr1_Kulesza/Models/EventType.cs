using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AWWW_lab1_gr1_Kulesza.Models
{
    [Table("EventTypes")]
    public class EventType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? Name { get; set; }
        // * - 1
        public virtual ICollection<MatchEvent>? MatchEvents { get; set; }
        public EventType(string name)
        {
            Name = name;
        }
    
    }
}
