namespace AWWW_lab1_gr1_Kulesza.Models
{
    public class EventType
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        // * - 1
        public ICollection<MatchEvent>? MatchEvents { get; set; }
    }
}
