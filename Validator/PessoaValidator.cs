using FluentValidation;
using FluentValidationNetCore.Model;

namespace FluentValidationNetCore.Validator
{
    public class PessoaValidator : AbstractValidator<Pessoa>
    {
        public PessoaValidator()
        {
            RuleFor(x => x.Id).NotNull();
            RuleFor(x => x.Nome).Length(0, 10);
            RuleFor(x => x.Email).EmailAddress();
            RuleFor(x => x.Idade).InclusiveBetween(18, 60);
        }
    }
}