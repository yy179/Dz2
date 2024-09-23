using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_14_1.Models
{
    public class ArticleEntity
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public Guid AuthorId { get; set; }
        public AuthorEntity? Author { get; set; }
        public List<CommentEntity> Comments { get; set; } = [];

    }
}
