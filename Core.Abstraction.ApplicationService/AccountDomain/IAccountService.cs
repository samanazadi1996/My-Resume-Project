using Core.Abstraction.ApplicationService.Common;
using Core.DomainModel.Identity;
using System.Threading.Tasks;

namespace Core.Abstraction.ApplicationService.AccountDomain
{
    public interface IAccountService
    {
        Task<IServiceResult<ApplicationUser>> GetUserByUserName(string userName);
    }
}