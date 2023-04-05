using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AWWW_lab1_gr1_Kulesza.Models
{
    [Table("Comments")]
    public class Comment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Content { get; set; }
        // 1 - *
        [Required]
        public virtual Article Article { get; set; } = null!;
        [Required]
        public int ArticleId { get; set; }
    }
}
