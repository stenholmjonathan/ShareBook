namespace ShareBookApi.Models
{
    public class BlogPost
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }

        public virtual int ProfileId { get; set; }
    }
}
