using BlogPostify.Domain.Commons;

namespace BlogPostify.Domain.Entities;

public class Comment : Auditable
{
    public long PostId { get; set; } 
    public long UserId { get; set; } 
    public string Content { get; set; }
    public long? ParentCommentId { get; set; } 

    // Navigation Properties
    public Post Post { get; set; }
    public User User { get; set; }
    public Comment ParentComment { get; set; }
    public ICollection<Comment> Replies { get; set; }
}
