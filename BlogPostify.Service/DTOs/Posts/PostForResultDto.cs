using BlogPostify.Domain.Entities;

namespace BlogPostify.Service.DTOs.Posts;

public class PostForResultDto
{
    public int Id { get; set; } 
    public string Title { get; set; }
    public string Content { get; set; }
    public string CoverImage { get; set; }
    public long UserId { get; set; }
    public bool IsPublished { get; set; }
    public ICollection<Comment> Comments { get; set; }
    public ICollection<Like> Likes { get; set; }
    public ICollection<BookMark> Bookmarks { get; set; }
    public ICollection<PostCategory> PostCategories { get; set; }
    public ICollection<PostTag> PostTags { get; set; }
}
