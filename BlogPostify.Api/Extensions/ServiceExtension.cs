using BlogPostify.Data.IRepositories;
using BlogPostify.Data.Repositories;
using BlogPostify.Service.Interfaces.Users;
using BlogPostify.Service.Mappers;
using BlogPostify.Service.Services.Users;

namespace BlogPostify.Api.Extensions;
public static class ServiceExtension
{
    public static void AddCustomServices(this IServiceCollection services)
    {
        //Folder Name: Generic Reporitory
        services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

        //Folder Name: User Service
        services.AddScoped<IUserService, UserService>();











        // Mapping
        services.AddAutoMapper(typeof(MappingProfile));
    }
}