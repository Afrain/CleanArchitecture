using MediatR;

namespace CleanArchitecture.Application.UserCases.DeleteUser
{
    public sealed record DeleteUserRequest : IRequest<DeleteUserResponse>
    {
        public Guid Id { get; set; }
    }
}
