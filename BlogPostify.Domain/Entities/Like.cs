using BlogPostify.Domain.Commons;

namespace BlogPostify.Domain.Entities;

public class Like : Auditable<long>
{
    public long PostId { get; set; }
    public Post Post { get; set; }

    public int UserId { get; set; }
    public User User { get; set; }
}
