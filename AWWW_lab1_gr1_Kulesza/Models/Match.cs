namespace AWWW_lab1_gr1_Kulesza.Models
{
    public class Match
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Stadium { get; set; }
        public List<Article> Articles { get; set; }
        public Team HomeTeam { get; set; }
        public Team AwayTeam { get; set; }
        public List<MatchPlayer> MatchPlayers { get; set; }
    }
}
