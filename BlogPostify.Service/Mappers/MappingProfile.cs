using AutoMapper;
using BlogPostify.Domain.Entities;
using BlogPostify.Service.DTOs.Users;

namespace BlogPostify.Service.Mappers;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        // Folder Name :  User
        CreateMap<User, UserForUpdateDto>().ReverseMap();
        CreateMap<User, UserForResultDto>().ReverseMap();
        CreateMap<User, UserForCreationDto>().ReverseMap();
    }
}
