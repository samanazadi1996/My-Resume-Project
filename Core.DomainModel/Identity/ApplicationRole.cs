using Core.DomainModel.Common;
using Microsoft.AspNetCore.Identity;

namespace Core.DomainModel.Identity
{
    public class ApplicationRole : IdentityRole<int>, IEntity
    {
    }
}
