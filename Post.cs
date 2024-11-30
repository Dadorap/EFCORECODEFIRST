namespace EFCORECODEFIRST
{

    public class Post
    {
        public int Id { get; set; }
        public string Content { get; set; }

        public int IdBlog { get; set; }
        public Blog Blog { get; set; }
    }

}
