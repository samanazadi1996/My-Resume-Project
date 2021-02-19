using Core.Abstraction.ApplicationService.Common;
using Core.DomainModel.ArticleModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Abstraction.ApplicationService.ArticleDomain
{
    public interface IGetArticleService
    {
        Task<IServiceResult<List<Article>>> GetAll();
    }
}