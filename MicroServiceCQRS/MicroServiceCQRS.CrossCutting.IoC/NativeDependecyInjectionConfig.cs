using MicroServiceCQRS.CrossCutting.Bus;
using MicroServiceCQRS.CrossCutting.Bus.Interfaces;
using MicroServiceCQRS.Infra.Data.Context;
using Microsoft.Extensions.DependencyInjection;

namespace MicroServiceCQRS.CrossCutting.IoC
{
    public static class NativeDependecyInjectionConfig
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<IMediatorHandler, ServiceBus>();

            services.AddScoped<MicroServiceCQRSContext>();
        }
    }
}
