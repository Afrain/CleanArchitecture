using FluentValidation;

namespace CleanArchitecture.Application.UserCases.GetAllUser
{
    public sealed class GetAllUserValidator : AbstractValidator<GetAllUserRequest>
    {
        public GetAllUserValidator() { }
    }
}
