namespace ShareBook.Exceptions
{
    public class BlogPostNotFoundException : Exception
    {
        //public BlogPostNotFoundException() { }

        public BlogPostNotFoundException(string message) : base(message) { }

        //public ProfileNotFoundException(string message, Exception innerException) : base(message, innerException) { }     
    }
}
