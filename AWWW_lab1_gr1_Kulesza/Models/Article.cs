using System.ComponentModel.DataAnnotations;

namespace AWWW_lab1_gr1_Kulesza.Models
{
    public class Article
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Lead { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public DateTime CreationDate { get; set; }
        [Required]
        // 1 - *
        public virtual Author Author { get; set; } = null!;
        public int? AuthorId { get; set; }
        // * - 1
        public ICollection<Comment>? Comments { get; set; }
        // 1 - *
        public virtual Category Category { get; set; } = null!;
        public int? CategoryId { get; set; }
        // * - *
        public ICollection<Tag>? Tags { get; set; }
        // 0..1 - *
        public virtual Match? Match { get; set; }
        public int? MatchId { get; set; }
    }
}
