using Core.Abstraction.DataAccessLayer;
using Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Implementation.DataAccessLayer
{
    public static class Container
    {
        public static IServiceCollection AddDataAccessLayerServices(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<ApplicationDbContext>(conf =>
            {
                conf.UseSqlServer(connectionString);
            });
            services.AddScoped(typeof(IUnitOfWork<>), typeof(UnitOfWork<>));
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            return services;
        }
    }
}
