using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Implementation.ApplicationService.AccountDomain
{
    public static class Container
    {
        public static IServiceCollection AddAccountDomainService(this IServiceCollection services)
        {
            //services.AddTransient(typeof(IAccountService), typeof(AccountService));

            return services;
        }
    }
}
