using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;

namespace Presentation.WebApi.Infrastructure.Configurations
{
    public static class SwaggerConfigurationExtensions
    {
        public static void AddSwaggerServices(this IServiceCollection services)
        {
            services.AddSwaggerGen();
        }

        public static void UseCustomSwagger(this IApplicationBuilder app, string url)
        {
            app.UseSwagger();
            app.UseSwaggerUI(option =>
            {
                option.SwaggerEndpoint("/swagger/v1/swagger.json", "Sharp API V1");
                option.RoutePrefix = url;
            });

        }

    }
}
