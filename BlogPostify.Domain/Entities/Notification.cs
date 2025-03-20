using BlogPostify.Domain.Commons;

namespace BlogPostify.Domain.Entities;

public class Notification : Auditable<long>
{
    public long UserId { get; set; }
    public string Message { get; set; }
    public bool IsRead { get; set; }
}
