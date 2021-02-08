using Infrastructure.DomainModel.ArticleModels;
using Infrastructure.DomainModel.Common;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace Infrastructure.DomainModel.Identity
{
    public class ApplicationUser : IdentityUser<int>, IEntity
    {
        public virtual IList<Article> Articles { get; set; }
    }
}
