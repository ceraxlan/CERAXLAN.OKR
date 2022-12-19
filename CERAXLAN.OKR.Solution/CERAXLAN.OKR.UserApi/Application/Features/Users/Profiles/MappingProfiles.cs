using AutoMapper;
using CERAXLAN.Core.Persistence.Paging;
using CERAXLAN.Core.Security.Entities;
using CERAXLAN.OKR.UserApi.Application.Features.Users.Commands.CreateUser;
using CERAXLAN.OKR.UserApi.Application.Features.Users.Commands.DeleteUser;
using CERAXLAN.OKR.UserApi.Application.Features.Users.Commands.UpdateUser;
using CERAXLAN.OKR.UserApi.Application.Features.Users.Dtos;
using CERAXLAN.OKR.UserApi.Application.Features.Users.Models;

namespace CERAXLAN.OKR.UserApi.Application.Features.Users.Profiles
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<User, CreateUserCommand>().ReverseMap();
            CreateMap<User, CreatedUserDto>().ReverseMap();

            CreateMap<User, UpdateUserCommand>().ReverseMap();
            CreateMap<User, UpdatedUserDto>().ReverseMap();

            //CreateMap<User, UpdateUserFromAuthCommand>().ReverseMap();
            //CreateMap<User, UpdatedUserFromAuthDto>().ReverseMap();

            CreateMap<User, DeleteUserCommand>().ReverseMap();
            CreateMap<User, DeletedUserDto>().ReverseMap();

            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<User, UserListDto>().ReverseMap();
            CreateMap<IPaginate<User>, UserListModel>().ReverseMap();
        }
    }
}
