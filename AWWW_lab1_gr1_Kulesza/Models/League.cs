using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AWWW_lab1_gr1_Kulesza.Models
{
    [Table("Leagues")]
    public class League
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Country { get; set; }
        public int Level { get; set; }
        //* - 1
        public virtual ICollection<Team>? Teams { get; set; }

        public League(string name, string country, int level)
        {
            Name = name;
            Country = country;
            Level = level;
        }
    }
}
