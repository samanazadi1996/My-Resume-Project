using Infrastructure.Implementation.ApplicationService.AccountDomain;
using Infrastructure.Implementation.ApplicationService.ArticleDomain;
using Infrastructure.Implementation.ApplicationService.Common;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Implementation.ApplicationService
{
    public static class Continer
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddCommonService();
            services.AddAccountDomainService();
            services.AddArticleDomainService();
            return services;
        }
    }
}
