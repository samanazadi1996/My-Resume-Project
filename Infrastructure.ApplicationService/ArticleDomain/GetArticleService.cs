using Core.Abstraction.ApplicationService.ArticleDomain;
using Core.Abstraction.ApplicationService.Common;
using Core.Abstraction.DataAccessLayer;
using Core.DomainModel.ArticleModels;
using Infrastructure.Implementation.ApplicationService.Common;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infrastructure.Implementation.ApplicationService.ArticleDomain
{
    public class GetArticleService : IGetArticleService
    {
        private readonly IUnitOfWork<Article> unitOfWork;

        public GetArticleService(IUnitOfWork<Article> unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public async Task<IServiceResult<List<Article>>> GetAll()
        {
            var result = unitOfWork.Repository.Get().ToList();
            return new ServiceResult<List<Article>>().Ok(result);
        }
    }
}