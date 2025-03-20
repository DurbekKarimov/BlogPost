using BlogPostify.Domain.Commons;

namespace BlogPostify.Domain.Entities;

public class Comment : Auditable<long>
{
    public long PostId { get; set; } 
    public long UserId { get; set; } 
    public string Content { get; set; }
    public long  ParentCommentId { get; set; } 
    public Comment ParentComment { get; set; }
    public ICollection<Comment> Replies { get; set; }
}
