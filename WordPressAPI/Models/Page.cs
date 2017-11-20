namespace WordPressAPI.Models
{
    public class Page
    {
        public string Description { get; set; }
        public bool Hierarchical { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public object[] Taxonomies { get; set; }
        public string RestBase { get; set; }
        public Links Links { get; set; }
    }
}
