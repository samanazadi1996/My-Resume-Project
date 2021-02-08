using Core.Abstraction.ApplicationService.Common;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Implementation.ApplicationService.Common
{
    public static class Container
    {
        public static IServiceCollection AddCommonService(this IServiceCollection services)
        {
            services.AddTransient(typeof(IServiceResult<>), typeof(ServiceResult<>));

            return services;
        }
    }
}
