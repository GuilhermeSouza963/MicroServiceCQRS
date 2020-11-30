using System;

namespace MicroServiceCQRS.Domain.Commands.DisciplinaObjetoCommands
{
    public class RegisterNewDisciplinaObjetoCommand : DisciplinaObjetoCommand
    {
        public RegisterNewDisciplinaObjetoCommand(int disciplinaId, int objetoId, short ordem, int? pesquisaId, int statusId, string usuario, DateTime criadoEm, DateTime atualizadoEm)
        {
            DisciplinaId = disciplinaId;
            ObjetoId = objetoId;
            Ordem = ordem;
            PesquisaId = pesquisaId;
            StatusId = statusId;
            Usuario = usuario;
            CriadoEm = criadoEm;
            AtualizadoEm = atualizadoEm;
        }

        public override bool IsValid()
        {
            return true;
        }

    }
}
