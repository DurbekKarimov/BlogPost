using BlogPostify.Domain.Commons;

namespace BlogPostify.Domain.Entities;

public class Tag : Auditable
{
    public string TagName { get; set; }

    // Relations
    public ICollection<PostTag> PostTags { get; set; }
}
