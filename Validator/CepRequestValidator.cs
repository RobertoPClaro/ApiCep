using FluentValidation;

namespace ApiCep.Validator
{
    public class CepRequestValidator : AbstractValidator<CepRequest>
    {
        public CepRequestValidator()
        {
            //RuleFor(x => x.Cep).Length(8,8);
            RuleFor(x => x.Cep).Matches("^\\d{8}$");
        }

    }
}
