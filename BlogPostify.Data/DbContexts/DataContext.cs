using BlogPostify.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace BlogPostify.Data.DbContexts;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(
           Assembly.GetExecutingAssembly());

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
        // postCategory
        modelBuilder.Entity<PostCategory>()
        .HasOne(pc => pc.Category)
        .WithMany(c => c.PostCategories)
        .HasForeignKey(pc => pc.CategoryId)
        .OnDelete(DeleteBehavior.Cascade); // Yoki kerakli o‘zgarish
    }


}
