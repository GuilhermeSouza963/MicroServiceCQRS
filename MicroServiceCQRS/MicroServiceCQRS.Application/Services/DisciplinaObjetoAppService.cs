using AutoMapper;
using FluentValidation.Results;
using MicroServiceCQRS.Application.Interfaces;
using MicroServiceCQRS.Application.ViewModels;
using MicroServiceCQRS.CrossCutting.Bus.Interfaces;
using MicroServiceCQRS.Domain.Commands.DisciplinaObjetoCommands;
using MicroServiceCQRS.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MicroServiceCQRS.Application.Services
{
    public class DisciplinaObjetoAppService : IDisciplinaObjetoAppService
    {
        private readonly IMapper _mapper;
        private readonly IDisciplinaObjetoRepository _disciplinaObjetoRepository;
        private readonly IMediatorHandler _mediator;

        public DisciplinaObjetoAppService(IMapper mapper,
                                IDisciplinaObjetoRepository disciplinaObjetoRepository,
                                IMediatorHandler mediator)
        {
            _mapper = mapper;
            _disciplinaObjetoRepository = disciplinaObjetoRepository;
            _mediator = mediator;
        }
        public async Task<DisciplinaObjetoViewModel> GetById(int disciplinaId, int objetoId)
        {
            return _mapper.Map<DisciplinaObjetoViewModel>(await _disciplinaObjetoRepository.GetById(disciplinaId, objetoId));
        }
        public async Task<ValidationResult> Add(DisciplinaObjetoViewModel disciplinaObjeto)
        {
            var registerCommand = _mapper.Map<RegisterNewDisciplinaObjetoCommand>(disciplinaObjeto);
            return await _mediator.SendCommand(registerCommand);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }


    }
}
