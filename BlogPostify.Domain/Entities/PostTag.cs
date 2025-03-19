using BlogPostify.Domain.Commons;

namespace BlogPostify.Domain.Entities;

public class PostTag : Auditable
{
    public long TagId { get; set; }
    public Tag Tag { get; set; }
    public long PostId { get; set; }
    public Post Post { get; set; }
}
