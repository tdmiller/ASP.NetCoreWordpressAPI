namespace WordPressAPI.Models
{
    public class RootObject
    {
        public Post Post { get; set; }
        public Page Page { get; set; }
        public Attachment Attachment { get; set; }
        public Feedback Feedback { get; set; }
        public Category Category { get; set; }
        public PostTag PostTag { get; set; }
    }
}