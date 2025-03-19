using BlogPostify.Domain.Commons;

namespace BlogPostify.Domain.Entities;

public class PostCategory: Auditable
{
    public long PostId { get; set; }
    public Post Post { get; set; }
    public long CategoryId { get; set; }
    public Category Category { get; set; }
}
