using BlogPostify.Domain.Entities;
using Microsoft.AspNetCore.Http;

namespace BlogPostify.Service.DTOs.Posts;

public class PostForUpdateDto
{
    public string Title { get; set; }
    public string Content { get; set; }
    public IFormFile CoverImage { get; set; }
    public long UserId { get; set; }
    public bool IsPublished { get; set; }
}
