namespace ShareBookApi.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }

        public int ProfileId { get; set; }
        public Profile Profile { get; set; }
    }
}
