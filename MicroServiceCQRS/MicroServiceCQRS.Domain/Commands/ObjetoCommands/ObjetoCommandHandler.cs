using FluentValidation.Results;
using MediatR;
using MicroServiceCQRS.CrossCutting.Utils.Messaging;
using MicroServiceCQRS.Domain.Entities;
using MicroServiceCQRS.Domain.Events;
using MicroServiceCQRS.Domain.Events.ObjetoEvents;
using MicroServiceCQRS.Domain.Interfaces;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace MicroServiceCQRS.Domain.Commands.ObjetoCommands
{
    public class ObjetoCommandHandler : CommandHandler, IRequestHandler<RegisterNewObjetoCommand, ValidationResult>
    {
        private readonly IObjetoRepository _objetoRepository;

        public ObjetoCommandHandler(IObjetoRepository objetoRepository)
        {
            _objetoRepository = objetoRepository;
        }

        public async Task<ValidationResult> Handle(RegisterNewObjetoCommand message, CancellationToken cancellationToken)
        {
            if (!message.IsValid()) return message.ValidationResult;

            var objeto = new Objeto(
                Guid.NewGuid(),                
                message.ObjetoIdPai,
                message.ObjetoIdPaiPrincipal,
                message.ObjetoTipoId,
                message.ModeloId,
                message.Titulo,
                message.Descricao,
                message.Conteudo,
                message.DataExibirInicio,
                message.DataExibirFim,
                message.Ordem,
                message.SituacaoId,
                message.PessoaId,
                message.Urgente,
                message.DataAula,
                message.StatusId,
                message.Usuario,
                message.CriadoEm,
                message.AtualizadoEm
                );

            objeto.AddDomainEvent(new ObjetoRegisteredEvent(
                objeto.Id,
                objeto.ObjetoIdPai,
                objeto.ObjetoIdPaiPrincipal,
                objeto.ObjetoTipoId,
                objeto.ModeloId,
                objeto.Titulo,
                objeto.Descricao,
                objeto.Conteudo,
                objeto.DataExibirInicio,
                objeto.DataExibirFim,
                objeto.Ordem,
                objeto.SituacaoId,
                objeto.PessoaId,
                objeto.Urgente,
                objeto.DataAula,
                objeto.StatusId,
                objeto.Usuario,
                objeto.CriadoEm,
                objeto.AtualizadoEm));

            _objetoRepository.Add(objeto);

            return await Commit(_objetoRepository.UnitOfWork);
        }
    }
}
