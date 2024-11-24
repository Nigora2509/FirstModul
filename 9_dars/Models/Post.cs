namespace _9_dars.Models
{
    public class Post
    {
        public Guid Id { get; set; }

        public string QwnerName { get; set; }

        public string Description { get; set; }

        public string Type { get; set; }

        public DateTime Posted { get; set; }

        public int QuantityLikes { get; set; }

        public List<string> Comments { get; set; } = new List<string>();

        public List<string> ViewerNames { get; set; } = new List<string>();

    }
}
