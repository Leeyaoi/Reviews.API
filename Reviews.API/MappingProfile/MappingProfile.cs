using AutoMapper;
using Reviews.API.DTO.ActorDtos;
using Reviews.API.DTO.DirectorDtos;
using Reviews.API.DTO.FilmDtos;
using Reviews.API.DTO.ReviewDtos;
using Reviews.API.DTO.RoleDtos;
using Reviews.API.DTO.UserDtos;
using Reviews.API.Models;

namespace Reviews.API.MappingProfile;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Actor, ActorDto>().ReverseMap();
        CreateMap<Actor, CreateActorDto>().ReverseMap();
        CreateMap<ActorDto, CreateActorDto>().ReverseMap();

        CreateMap<Director, DirectorDto>().ReverseMap();
        CreateMap<Director, CreateDirectorDto>().ReverseMap();
        CreateMap<DirectorDto, CreateDirectorDto>().ReverseMap();

        CreateMap<Film, FilmDto>().ReverseMap();
        CreateMap<Film, CreateFilmDto>().ReverseMap();
        CreateMap<FilmDto, CreateFilmDto>().ReverseMap();

        CreateMap<Review, ReviewDto>().ReverseMap();
        CreateMap<Review, CreateReviewDto>().ReverseMap();
        CreateMap<ReviewDto, CreateReviewDto>().ReverseMap();

        CreateMap<Role, RoleDto>().ReverseMap();
        CreateMap<Role, CreateRoleDto>().ReverseMap();
        CreateMap<RoleDto, CreateRoleDto>().ReverseMap();

        CreateMap<User, UserDto>().ReverseMap();
        CreateMap<User, CreateUserDto>().ReverseMap();
        CreateMap<UserDto, CreateUserDto>().ReverseMap();
    }
}
