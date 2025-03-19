using BlogPostify.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlogPostify.Data.DbContexts;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options) { }
    public DbSet<User> Users { get; set; }
    public DbSet<Post> Posts { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Tag> Tags { get; set; }
    public DbSet<PostCategory> PostCategories { get; set; }
    public DbSet<PostTag> PostTags { get; set; }
    public DbSet<Comment> Comments { get; set; }
    public DbSet<Like> Likes { get; set; }
    public DbSet<BookMark> Bookmarks { get; set; }
    public DbSet<Notification> Notifications { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // PostCategory - Composite Primary Key
        modelBuilder.Entity<PostCategory>()
            .HasKey(pc => new { pc.PostId, pc.CategoryId });

        // PostTag - Composite Primary Key
        modelBuilder.Entity<PostTag>()
            .HasKey(pt => new { pt.PostId, pt.TagId });

        // Like - Composite Primary Key
        modelBuilder.Entity<Like>()
            .HasKey(l => new { l.PostId, l.UserId });

        // Bookmark - Composite Primary Key
        modelBuilder.Entity<BookMark>()
            .HasKey(b => new { b.UserId, b.PostId });

        // Comment - Self-referencing Relationship
        modelBuilder.Entity<Comment>()
            .HasOne(c => c.ParentComment)
            .WithMany(c => c.Replies)
            .HasForeignKey(c => c.ParentCommentId)
            .OnDelete(DeleteBehavior.NoAction); // Prevent cascade delete cycles

        // User - Post Relationship
        modelBuilder.Entity<Post>()
            .HasOne(p => p.User)
            .WithMany(u => u.Posts)
            .HasForeignKey(p => p.UserId)
            .OnDelete(DeleteBehavior.NoAction);

        // User - Comment Relationship
        modelBuilder.Entity<Comment>()
            .HasOne(c => c.User)
            .WithMany(u => u.Comments)
            .HasForeignKey(c => c.UserId)
            .OnDelete(DeleteBehavior.NoAction);

        // User - Like Relationship
        modelBuilder.Entity<Like>()
            .HasOne(l => l.User)
            .WithMany(u => u.Likes)
            .HasForeignKey(l => l.UserId)
            .OnDelete(DeleteBehavior.NoAction);

        // User - Bookmark Relationship
        modelBuilder.Entity<BookMark>()
            .HasOne(b => b.User)
            .WithMany(u => u.Bookmarks)
            .HasForeignKey(b => b.UserId)
            .OnDelete(DeleteBehavior.NoAction);

        // User - Notification Relationship
        modelBuilder.Entity<Notification>()
            .HasOne(n => n.User)
            .WithMany(u => u.Notifications)
            .HasForeignKey(n => n.UserId)
            .OnDelete(DeleteBehavior.NoAction);
    }


}
