using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
using MicroServiceCQRS.Services.Api.Configurations;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using NetDevPack.Identity.User;

namespace MicroServiceCQRS.Services.Api
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IHostEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", true, true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", true);

            if (env.IsDevelopment())
            {
                builder.AddUserSecrets<Startup>();
            }

            builder.AddEnvironmentVariables();
            Configuration = builder.Build();
        }        

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            // Setting DBContexts
            services.AddDatabaseConfiguration(Configuration);

            // Interactive AspNetUser (logged in)
            services.AddAspNetUserConfiguration();

            // AutoMapper Settings
            services.AddAutoMapperConfiguration();

            // Swagger Config
            services.AddSwaggerConfiguration();

            services.AddMediatR(typeof(Startup));

            services.AddDependencyInjectionConfiguration();

            //services.AddScoped<IMediatorHandler, ServiceBus>();

            ////Application
            //services.AddScoped<IObjetoAppService, ObjetoAppService>();
            //services.AddScoped<IDisciplinaObjetoAppService, DisciplinaObjetoAppService>();

            ////Domain - Events
            //services.AddScoped<INotificationHandler<ObjetoRegisteredEvent>, ObjetoEventHandler>();
            //services.AddScoped<INotificationHandler<DisciplinaObjetoRegisteredEvent>, DisciplinaObjetoEventHandler>();

            ////Domain - Commands

            //services.AddScoped<IRequestHandler<RegisterNewObjetoCommand, ValidationResult>, ObjetoCommandHandler>();
            //services.AddScoped<IRequestHandler<RegisterNewDisciplinaObjetoCommand, ValidationResult>, DisciplinaObjetoCommandHandler>();

            ////Infra
            //services.AddScoped<IObjetoRepository, ObjetoRepository>();
            //services.AddScoped<IDisciplinaObjetoRepository, DisciplinaObjetoRepository>();
            //services.AddScoped<MicroServiceCQRSContext>();


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseCors(c =>
            {
                c.AllowAnyHeader();
                c.AllowAnyMethod();
                c.AllowAnyOrigin();
            });

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseSwaggerSetup();
        }
    }
}
