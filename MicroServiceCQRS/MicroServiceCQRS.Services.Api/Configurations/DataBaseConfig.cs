using MicroServiceCQRS.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroServiceCQRS.Services.Api.Configurations
{
    public static class DataBaseConfig
    {
        public static void AddDatabaseConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            services.AddDbContext<MicroServiceCQRSContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            // adicionar outro contexto
            //services.AddDbContext<OutroContext>(options =>
            //    options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
        }
    }
}
