public class Post
{
    public int Id { get; set; }
    public string UserName { get; set; } = "Anon";
    public string Content { get; set; } = string.Empty;
    public DateTime PostDate { get; set; } = DateTime.UtcNow;
    public int Likes { get; set; }
    public List<Comment> Comments { get; set; } = new();
}

public class Comment
{
    public int Id { get; set; }
    public int PostId { get; set; }
    public string UserName { get; set; } = "Anon";
    public string Content { get; set; } = string.Empty;
    public DateTime CommentDate { get; set; } = DateTime.UtcNow;
}