namespace WordPressAPI.Models
{
    public class Links
    {
        public Collection[] Collections { get; set; }
        public WpItems[] WpItems { get; set; }
        public Cury[] Curies { get; set; }
    }
}
