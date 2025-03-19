using BlogPostify.Domain.Commons;

namespace BlogPostify.Domain.Entities;

public class BookMark : Auditable
{
    public long UserId { get; set; }
    public User User { get; set; }

    public long PostId { get; set; }
    public Post Post { get; set; }
}
