using Core.Abstraction.ApplicationService.AccountDomain;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Implementation.ApplicationService.AccountDomain
{
    public static class Container
    {
        public static IServiceCollection AddAccountDomainService(this IServiceCollection services)
        {
            services.AddTransient(typeof(IAccountService), typeof(AccountService));

            return services;
        }
    }
}
