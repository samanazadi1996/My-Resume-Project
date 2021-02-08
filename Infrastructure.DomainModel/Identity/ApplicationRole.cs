using Infrastructure.DomainModel.Common;
using Microsoft.AspNetCore.Identity;

namespace Infrastructure.DomainModel.Identity
{
    public class ApplicationRole : IdentityRole<int>, IEntity
    {
    }
}
