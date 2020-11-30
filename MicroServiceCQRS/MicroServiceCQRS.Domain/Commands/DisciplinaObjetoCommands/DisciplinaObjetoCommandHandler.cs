using FluentValidation.Results;
using MediatR;
using MicroServiceCQRS.CrossCutting.Utils.Messaging;
using MicroServiceCQRS.Domain.Entities;
using MicroServiceCQRS.Domain.Events.DisciplinaObjetoEvents;
using MicroServiceCQRS.Domain.Interfaces;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace MicroServiceCQRS.Domain.Commands.DisciplinaObjetoCommands
{
    public class DisciplinaObjetoCommandHandler : CommandHandler, IRequestHandler<RegisterNewDisciplinaObjetoCommand, ValidationResult>
    {
        private readonly IDisciplinaObjetoRepository _disciplinaObjetoRepository;

        public DisciplinaObjetoCommandHandler(IDisciplinaObjetoRepository disciplinaObjetoRepository)
        {
            _disciplinaObjetoRepository = disciplinaObjetoRepository;
        }

        public async Task<ValidationResult> Handle(RegisterNewDisciplinaObjetoCommand message, CancellationToken cancellationToken)
        {
            if (!message.IsValid()) return message.ValidationResult;

            var disciplinaObjeto = new DisciplinaObjeto(
                Guid.NewGuid(),
                message.DisciplinaId,
                message.ObjetoId,
                message.Ordem,
                message.PesquisaId,
                message.StatusId,
                message.Usuario,
                message.CriadoEm,
                message.AtualizadoEm
                );

            disciplinaObjeto.AddDomainEvent(new DisciplinaObjetoRegisteredEvent(
                disciplinaObjeto.Id,
                disciplinaObjeto.DisciplinaId,
                disciplinaObjeto.ObjetoId,
                disciplinaObjeto.Ordem,
                disciplinaObjeto.PesquisaId,
                disciplinaObjeto.StatusId,
                disciplinaObjeto.Usuario,
                disciplinaObjeto.CriadoEm,
                disciplinaObjeto.AtualizadoEm)); ;

            _disciplinaObjetoRepository.Add(disciplinaObjeto);

            return await Commit(_disciplinaObjetoRepository.UnitOfWork);
        }
    }
}
