namespace AWWW_lab1_gr1_Kulesza.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        // * - 1
        public ICollection<Article>? Articles { get; set; }
    }
}
