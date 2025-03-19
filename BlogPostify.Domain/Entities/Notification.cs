using BlogPostify.Domain.Commons;

namespace BlogPostify.Domain.Entities;

public class Notification : Auditable
{
    public long UserId { get; set; }
    public User User { get; set; }
    public string Message { get; set; }
    public bool IsRead { get; set; }
}
