using AutoMapper;
using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Application.UserCases.CreateUser
{
    public sealed class CreateUserMapper : Profile
    {
        public CreateUserMapper()
        {
            CreateMap<CreateUserRequest, User>()
                .ConstructUsing(request => new User(request.Nome, request.Email));

            CreateMap<User, CreateUserResponse>();
        }
    }
}
