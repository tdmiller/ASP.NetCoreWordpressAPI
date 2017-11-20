namespace WordPressAPI.Models
{
    public class Post
    {
        public string Description { get; set; }
        public bool Hierarchical { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public string[] Taxonomies { get; set; }
        public string RestBase { get; set; }
        public Links Links { get; set; }
    }
}
