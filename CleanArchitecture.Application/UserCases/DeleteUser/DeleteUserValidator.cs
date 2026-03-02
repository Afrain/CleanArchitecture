using FluentValidation;

namespace CleanArchitecture.Application.UserCases.DeleteUser
{
    public sealed class DeleteUserValidator : AbstractValidator<DeleteUserRequest>
    {
        public DeleteUserValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty()
                .WithMessage("User ID is required.");
        }
    }
}
