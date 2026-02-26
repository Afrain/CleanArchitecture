using MediatR;

namespace CleanArchitecture.Application.UserCases.CreateUser
{
    public sealed record CreateUserRequest(string? Name, string? Email) : IRequest<CreateUserResponse>;
}
