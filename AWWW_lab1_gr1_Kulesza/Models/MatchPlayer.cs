namespace AWWW_lab1_gr1_Kulesza.Models
{
    public class MatchPlayer
    {
        public int Id { get; set; }
        // 1 - *
        public virtual Match Match { get; set; } = null!;
        public int? MatchId { get; set; }
        // 1 - *
        public virtual Position Position { get; set; } = null!;
        public int? PositionId { get; set; }
        // 1 - *
        public virtual Player Player { get; set; } = null!;
        public int? PlayerId { get; set; }
        // * - 0..1
        public ICollection<MatchEvent>? MatchEvents { get; set; }
    }
}
