using Core.DomainModel.ArticleModels;
using Core.DomainModel.Common;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace Core.DomainModel.Identity
{
    public class ApplicationUser : IdentityUser<int>, IEntity
    {
        public virtual IList<Article> Articles { get; set; }
    }
}
