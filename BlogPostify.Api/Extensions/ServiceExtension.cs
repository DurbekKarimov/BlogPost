using BlogPostify.Data.IRepositories;
using BlogPostify.Data.Repositories;
using BlogPostify.Service.Interfaces.Categories;
using BlogPostify.Service.Interfaces.PostCategories;
using BlogPostify.Service.Interfaces.Posts;
using BlogPostify.Service.Interfaces.PostTags;
using BlogPostify.Service.Interfaces.Tags;
using BlogPostify.Service.Interfaces.Users;
using BlogPostify.Service.Mappers;
using BlogPostify.Service.Services.Categories;
using BlogPostify.Service.Services.PostCategories;
using BlogPostify.Service.Services.Posts;
using BlogPostify.Service.Services.PostTags;
using BlogPostify.Service.Services.Tags;
using BlogPostify.Service.Services.Users;

namespace BlogPostify.Api.Extensions;
public static class ServiceExtension
{
    public static void AddCustomServices(this IServiceCollection services)
    {
        //Folder Name: Generic Reporitory
        services.AddScoped(typeof(IRepository<,>), typeof(Repository<,>));

        //Folder Name: User Service
        services.AddScoped<IUserService, UserService>();

        // Folder Name : Post Service
        services.AddScoped<IPostService,PostService>();

        // Folder Name : Category Service
        services.AddScoped<ICategoryService,CategoryService>();

        // Folder Name : Tag Service
        services.AddScoped<ITagService,TagService>();

        // Folder Name : PostCategory Service
        services.AddScoped<IPostCategoryService,PostCategoryService>();
        
        // FOlder Name : PostTag Service
        services.AddScoped<IPostTagService,PostTagService>();

        // Mapping
        services.AddAutoMapper(typeof(MappingProfile));
    }
}