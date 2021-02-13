using Infrastructure.Implementation.ApplicationService;
using Infrastructure.Implementation.ApplicationService.Common;
using Infrastructure.Implementation.DataAccessLayer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Presentation.WebApi.Infrastructure.Configurations;

namespace Presentation.WebApi
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        private readonly SiteSettings _SiteSettings;

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            _SiteSettings = configuration.GetSection(nameof(SiteSettings)).Get<SiteSettings>();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDataAccessLayerServices(_SiteSettings.dataBaseConectionString);
            services.AddCustomIdentity(_SiteSettings.identitySettings);
            services.Configure<SiteSettings>(Configuration.GetSection(nameof(SiteSettings)));
            services.AddApplicationServices();
            services.AddControllers();
            services.AddSwaggerServices();
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

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
            app.UseCustomSwagger(_SiteSettings.swaggerRoutePrefix);
        }
    }

}
