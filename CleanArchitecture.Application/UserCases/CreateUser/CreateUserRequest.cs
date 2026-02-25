using MediatR;

namespace CleanArchitecture.Application.UserCases.CreateUser
{
    public sealed record CreateUserRequest(string? Nome, string? Email) : IRequest<CreateUserResponse>;
}
