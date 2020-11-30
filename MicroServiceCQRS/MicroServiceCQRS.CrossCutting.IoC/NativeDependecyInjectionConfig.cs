using FluentValidation.Results;
using MediatR;
using MicroServiceCQRS.Application.Interfaces;
using MicroServiceCQRS.Application.Services;
using MicroServiceCQRS.CrossCutting.Bus;
using MicroServiceCQRS.CrossCutting.Bus.Interfaces;
using MicroServiceCQRS.Domain.Commands.DisciplinaObjetoCommands;
using MicroServiceCQRS.Domain.Commands.ObjetoCommands;
using MicroServiceCQRS.Domain.Events.DisciplinaObjetoEvents;
using MicroServiceCQRS.Domain.Events.ObjetoEvents;
using MicroServiceCQRS.Domain.Interfaces;
using MicroServiceCQRS.Infra.Data.Context;
using MicroServiceCQRS.Infra.Data.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace MicroServiceCQRS.CrossCutting.IoC
{
    public static class NativeDependecyInjectionConfig
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // Bus Mediator
            services.AddScoped<IMediatorHandler, ServiceBus>();

            //Application
            services.AddScoped<IObjetoAppService, ObjetoAppService>();
            services.AddScoped<IDisciplinaObjetoAppService, DisciplinaObjetoAppService>();

            //Domain - Events
            services.AddScoped<INotificationHandler<ObjetoRegisteredEvent>, ObjetoEventHandler>();
            services.AddScoped<INotificationHandler<DisciplinaObjetoRegisteredEvent>, DisciplinaObjetoEventHandler>();

            //Domain - Commands

            services.AddScoped<IRequestHandler<RegisterNewObjetoCommand, ValidationResult>, ObjetoCommandHandler>();
            services.AddScoped<IRequestHandler<RegisterNewDisciplinaObjetoCommand, ValidationResult>, DisciplinaObjetoCommandHandler>();

            //Infra
            services.AddScoped<IObjetoRepository, ObjetoRepository>();
            services.AddScoped<IDisciplinaObjetoRepository, DisciplinaObjetoRepository>();
            services.AddScoped<MicroServiceCQRSContext>();

        }
    }
}
