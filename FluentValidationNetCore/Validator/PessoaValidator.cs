using FluentValidation;
using FluentValidationNetCore.Models;

namespace FluentValidationNetCore.Validator
{
    public class PessoaValidator : AbstractValidator<Pessoa>
    {
        public PessoaValidator()
        {
            RuleFor(p => p.Id).NotNull();
            RuleFor(p => p.Nome).Length(0, 10);
            RuleFor(p => p.Email).EmailAddress();
            RuleFor(p => p.Idade).InclusiveBetween(18, 60);
        }
    }
}