namespace AWWW_lab1_gr1_Kulesza.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public Article Article { get; set; }
    }
}
