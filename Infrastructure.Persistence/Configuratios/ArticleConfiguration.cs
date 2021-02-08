using Infrastructure.DomainModel.ArticleModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configuratios
{
    public class ArticleConfiguration : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.HasOne(current => current.ApplicationUser)
                .WithMany(current => current.Articles)
                .HasForeignKey(current => current.ApplicationUserId)
                .IsRequired();
        }
    }
}
