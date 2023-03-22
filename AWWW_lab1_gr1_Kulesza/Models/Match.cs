namespace AWWW_lab1_gr1_Kulesza.Models
{
    public class Match
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string? Stadium { get; set; }
        // * - 0..1
        public ICollection<Article>? Articles { get; set; }
        // 1 - *
        public virtual Team HomeTeam { get; set; } = null!;
        public int? HomeTeamId { get; set; }
        // 1 - *
        public virtual Team AwayTeam { get; set; } = null!;
        public int? AwayTeamId { get; set; }
        // * - 1
        public ICollection<MatchPlayer>? MatchPlayers { get; set; }
        // * - 1
        public ICollection<MatchEvent>? MatchEvents { get; set; }
    }
}
