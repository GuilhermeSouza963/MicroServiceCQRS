using AutoMapper;
using FluentValidation.Results;
using MicroServiceCQRS.Application.Interfaces;
using MicroServiceCQRS.Application.ViewModels;
using MicroServiceCQRS.CrossCutting.Bus.Interfaces;
using MicroServiceCQRS.Domain.Commands.ObjetoCommands;
using MicroServiceCQRS.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MicroServiceCQRS.Application.Services
{
    public class ObjetoAppService : IObjetoAppService
    {
        private readonly IMapper _mapper;
        private readonly IObjetoRepository _objetoRepository;
        private readonly IMediatorHandler _mediator;

        public ObjetoAppService(IMapper mapper,
                                IObjetoRepository objetoRepository,
                                IMediatorHandler mediator)
        {
            _mapper = mapper;
            _objetoRepository = objetoRepository;
            _mediator = mediator;
        }

        public async Task<IEnumerable<ObjetoViewModel>> GetAll()
        {
            return _mapper.Map<IEnumerable<ObjetoViewModel>>(await _objetoRepository.GetAll());
        }

        public async Task<ObjetoViewModel> GetById(int objetoId)
        {
            return _mapper.Map<ObjetoViewModel>(await _objetoRepository.GetById(objetoId));
        }
        public async Task<ValidationResult> Add(ObjetoViewModel entidade)
        {
            var registerCommand = _mapper.Map<RegisterNewObjetoCommand>(entidade);
            return await _mediator.SendCommand(registerCommand);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

    }
}
