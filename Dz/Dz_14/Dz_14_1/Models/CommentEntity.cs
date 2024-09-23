using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_14_1.Models
{
    public class CommentEntity
    {
        public Guid Id { get; set; }
        public string Comment { get; set; } = string.Empty;
        public Guid ArticleId { get; set; }
        public ArticleEntity? Article { get; set; }
        public Guid UserId { get; set; }
        public UserEntity? User { get; set; }
    }
}
