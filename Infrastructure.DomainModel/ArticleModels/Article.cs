using Infrastructure.DomainModel.Common;
using Infrastructure.DomainModel.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.DomainModel.ArticleModels
{
    public class Article : BaseEntity
    {
        public string Content { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
        public int ApplicationUserId { get; set; }
    }
}
