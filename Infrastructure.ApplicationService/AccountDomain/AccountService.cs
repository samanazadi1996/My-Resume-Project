using Core.Abstraction.ApplicationService.AccountDomain;
using Core.Abstraction.ApplicationService.Common;
using Core.DomainModel.Identity;
using Infrastructure.Implementation.ApplicationService.Common;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace Infrastructure.Implementation.ApplicationService.AccountDomain
{
    public class AccountService : IAccountService
    {
        private readonly UserManager<ApplicationUser> userManager;

        public AccountService(UserManager<ApplicationUser> userManager)
        {
            this.userManager = userManager;
        }
        public async Task<IServiceResult<ApplicationUser>> GetUserByUserName(string userName)
        {
            var user = await userManager.FindByNameAsync(userName);
            return new ServiceResult<ApplicationUser>().Ok(user);
        }
    }
}