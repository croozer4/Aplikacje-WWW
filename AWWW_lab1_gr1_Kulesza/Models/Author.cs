namespace AWWW_lab1_gr1_Kulesza.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        // * - 1
        public ICollection<Article>? Articles { get; set; }
    }
}
