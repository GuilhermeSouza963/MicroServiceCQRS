using System;
using System.Collections.Generic;
using System.Text;

namespace MicroServiceCQRS.Domain.Commands.ObjetoCommands.Validations
{
    public class RegisterNewObjetoCommandValidation : ObjetoValidation<RegisterNewObjetoCommand>
    {
        public RegisterNewObjetoCommandValidation()
        {
            ValidateObjetoId();
            ValidateTitulo();
        }
    }
}
