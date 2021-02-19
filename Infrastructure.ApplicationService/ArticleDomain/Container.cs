

using Core.Abstraction.ApplicationService.ArticleDomain;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Implementation.ApplicationService.ArticleDomain
{
    public static class Container
    {
        public static IServiceCollection AddArticleDomainService(this IServiceCollection services)
        {
            services.AddTransient(typeof(IGetArticleService), typeof(GetArticleService));

            return services;
        }
    }
}
