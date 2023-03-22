namespace AWWW_lab1_gr1_Kulesza.Models
{
    public class Position
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        // * - 1
        public ICollection<MatchPlayer>? MatchPlayers { get; set; }
        // * - 1
        public ICollection<Player>? Players { get; set; }
    }
}
