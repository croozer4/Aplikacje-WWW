namespace AWWW_lab1_gr1_Kulesza.Models
{
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        // * - *
        public ICollection<Article>? Article { get; set; }
    }
}
