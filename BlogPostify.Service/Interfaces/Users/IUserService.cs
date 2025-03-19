using BlogPostify.Domain.Configurations;
using BlogPostify.Service.DTOs.Users;

namespace BlogPostify.Service.Interfaces.Users;

public interface IUserService
{
    Task<bool> RemoveAsync(long id);
    Task<UserForResultDto> RetrieveByIdasync(long id);
    Task<UserForResultDto> AddAsync(UserForCreationDto dto);
    Task<UserForResultDto> ModifyAsync(long id, UserForUpdateDto dto);
    Task<IEnumerable<UserForResultDto>> RetrieveAllAsync(PaginationParams @params);
}
