using Dz_14_1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dz_14_1.Configurations
{
    public class ArticleConfiguration : IEntityTypeConfiguration<ArticleEntity>
    {
        public void Configure(EntityTypeBuilder<ArticleEntity> builder)
        {
            builder.HasKey(a => a.Id);
            builder
                .HasMany(a => a.Comments)
                .WithOne(a => a.Article)
                .HasForeignKey(a => a.ArticleId);
        }
    }
}
