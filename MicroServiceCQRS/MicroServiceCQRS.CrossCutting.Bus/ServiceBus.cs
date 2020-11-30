﻿using FluentValidation.Results;
using MediatR;
using MicroServiceCQRS.CrossCutting.Bus.Interfaces;
using MicroServiceCQRS.CrossCutting.Utils.Messaging;
using System.Threading.Tasks;

namespace MicroServiceCQRS.CrossCutting.Bus
{
    public sealed class ServiceBus : IMediatorHandler
    {
        private readonly IMediator _mediator;

        public ServiceBus(IMediator mediator)
        {
            _mediator = mediator;
        }
        public async Task PublishEvent<T>(T @event) where T : Event
        {
            await _mediator.Publish(@event);
        }

        public async Task<ValidationResult> SendCommand<T>(T command) where T : Command
        {
            return await _mediator.Send(command);
        }
    }
}
