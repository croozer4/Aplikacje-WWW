using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AWWW_lab1_gr1_Kulesza.Models
{
    [Table("Articles")]
    public class Article
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Lead { get; set; }
        public string? Content { get; set; }
        public DateTime CreationDate { get; set; }
        // 1 - *
        [Required]
        public virtual Author Author { get; set; } = null!;
        [Required]
        public int AuthorId { get; set; }
        // * - 1
        public virtual ICollection<Comment>? Comments { get; set; }
        // 1 - *
        [Required]
        public virtual Category Category { get; set; } = null!;
        [Required]
        public int CategoryId { get; set; }
        // * - *
        public virtual ICollection<Tag>? Tags { get; set; }
        // 0..1 - *
        public virtual Match Match { get; set; } = null!;
        public int? MatchId { get; set; }
    }
}
