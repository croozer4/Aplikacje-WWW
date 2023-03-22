namespace AWWW_lab1_gr1_Kulesza.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public DateTime FoundingDate { get; set; }
        // * - 2
        public ICollection<Match>? Matches { get; set; }
        // 1 - *
        public virtual League League { get; set; } = null!;
        public int? LeagueId { get; set; }
        //* - 1
        public ICollection<Player>? Players { get; set; }
    }
}
