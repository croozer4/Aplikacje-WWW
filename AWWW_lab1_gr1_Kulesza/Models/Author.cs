using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AWWW_lab1_gr1_Kulesza.Models
{
    [Table("Authors")]
    public class Author
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        // * - 1
        public virtual ICollection<Article>? Articles { get; set; }
    
        public Author(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    
    }
}
