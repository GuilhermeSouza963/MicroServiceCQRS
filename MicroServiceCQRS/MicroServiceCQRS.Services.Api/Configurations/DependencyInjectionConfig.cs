using MicroServiceCQRS.CrossCutting.IoC;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace MicroServiceCQRS.Services.Api.Configurations
{
    public static class DependencyInjectionConfig
    {
        public static void AddDependencyInjectionConfiguration(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            NativeDependecyInjectionConfig.RegisterServices(services);
        }
    }
}
