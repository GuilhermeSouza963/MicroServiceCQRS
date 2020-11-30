using MicroServiceCQRS.Domain.Commands.ObjetoCommands.Validations;
using System;

namespace MicroServiceCQRS.Domain.Commands.ObjetoCommands
{
    public class RegisterNewObjetoCommand : ObjetoCommand
    {
        public RegisterNewObjetoCommand(int? objetoIdPai, int? objetoIdPaiPrincipal, short objetoTipoId, short? modeloId, string titulo, string descricao, string conteudo, DateTime dataExibirInicio, DateTime? dataExibirFim, short ordem, int? situacaoId, int pessoaId, bool? urgente, DateTime? dataAula, int statusId, string usuario, DateTime criadoEm, DateTime atualizadoEm)
        {            
            ObjetoIdPai = objetoIdPai;
            ObjetoIdPaiPrincipal = objetoIdPaiPrincipal;
            ObjetoTipoId = objetoTipoId;
            ModeloId = modeloId;
            Titulo = titulo;
            Descricao = descricao;
            Conteudo = conteudo;
            DataExibirInicio = dataExibirInicio;
            DataExibirFim = dataExibirFim;
            Ordem = ordem;
            SituacaoId = situacaoId;
            PessoaId = pessoaId;
            Urgente = urgente;
            DataAula = dataAula;
            StatusId = statusId;
            Usuario = usuario;
            CriadoEm = criadoEm;
            AtualizadoEm = atualizadoEm;
        }

        public override bool IsValid()
        {
            ValidationResult = new RegisterNewObjetoCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
