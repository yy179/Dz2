using Dz_14_1.Models;
using Microsoft.EntityFrameworkCore;

namespace Dz_14_1
{
    public class BlogDbContext : DbContext
    {
        public DbSet<UserEntity> Users { get; set; }
        public DbSet<CommentEntity> Comments { get; set; }
        public DbSet<ArticleEntity> Articles { get; set; }
        public DbSet<AuthorEntity> Authors { get; set; }

    }
}
