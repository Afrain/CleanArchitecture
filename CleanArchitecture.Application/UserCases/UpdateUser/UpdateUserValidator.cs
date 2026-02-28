using FluentValidation;

namespace CleanArchitecture.Application.UserCases.UpdateUser
{
    public sealed class UpdateUserValidator : AbstractValidator<UpdateUserRequest>
    {
        public UpdateUserValidator()
        {
            RuleFor(x => x.Name)
               .NotEmpty().WithMessage("Nome é obrigatório.")
               .MinimumLength(3).WithMessage("Nome deve ter no minimo 3 caracteres.")
               .MaximumLength(50).WithMessage("Nome deve ter no máximo 50 caracteres.");

            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("Email é obrigatório.")
                .MaximumLength(50).WithMessage("Email deve ter no máximo 50 caracteres.")
                .EmailAddress().WithMessage("Email inválido.");
        }
    }
}
