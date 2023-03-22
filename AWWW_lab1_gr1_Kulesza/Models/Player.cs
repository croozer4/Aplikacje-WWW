namespace AWWW_lab1_gr1_Kulesza.Models
{
    public class Player
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public string BirthDate { get; set; } = string.Empty;
        // 1 - *
        public virtual Team Team { get; set; } = null!;
        public int TeamId { get; set; }
        //1 - *
        public virtual Position Position { get; set; } = null!;
        public int? PositionId { get; set; }
        //* - 1
        public ICollection<MatchPlayer>? MatchPlayers { get; set; }
    }
}
