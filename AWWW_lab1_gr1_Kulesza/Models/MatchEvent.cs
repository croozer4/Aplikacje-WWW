namespace AWWW_lab1_gr1_Kulesza.Models
{
    public class MatchEvent
    {
        public int Id { get; set; }
        public int Minute { get; set; }
        // 1 - *
        public virtual Match Match { get; set; } = null!;
        public int MatchId { get; set; }
        // 0..1 - *
        public virtual MatchPlayer? MatchPlayer { get; set; }
        public int? MatchPlayerId { get; set; }
        // 1 - *
        public virtual EventType EventType { get; set; } = null!;
        public int EventTypeId { get; set; }
    }
}
