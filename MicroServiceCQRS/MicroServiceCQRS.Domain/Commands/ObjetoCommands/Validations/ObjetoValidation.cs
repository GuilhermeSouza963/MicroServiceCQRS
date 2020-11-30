using FluentValidation;

namespace MicroServiceCQRS.Domain.Commands.ObjetoCommands.Validations
{
    public abstract class ObjetoValidation<T> : AbstractValidator<T> where T : ObjetoCommand
    {
        protected void ValidateTitulo()
        {
            RuleFor(c => c.Titulo)
                .NotEmpty().WithMessage("Por favor preencha o campo Título")
                .Length(2, 256).WithMessage("O Título tem que ter entre 2 e 256 caracteres");
        }

        protected void ValidateObjetoId()
        {
            RuleFor(c => c.ObjetoId)
                .NotEqual(0);
        }
    }
}
