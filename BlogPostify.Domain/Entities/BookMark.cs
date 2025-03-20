using BlogPostify.Domain.Commons;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlogPostify.Domain.Entities;

[Table("book_mark")]
public class BookMark : Auditable<int>
{

    [Column("user_id")]
    [ForeignKey("User")]
    public int UserId { get; set; }
    public User User { get; set; }

    public long PostId { get; set; }
    public Post Post { get; set; }
}
