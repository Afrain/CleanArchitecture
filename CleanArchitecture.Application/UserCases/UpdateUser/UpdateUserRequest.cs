using MediatR;

namespace CleanArchitecture.Application.UserCases.UpdateUser
{
    public sealed record UpdateUserRequest : IRequest<UpdateUserResponse>
    {
        public Guid Id { get; init; }
        public string? Name { get; init; }
        public string? Email { get; init; }
    }
}
