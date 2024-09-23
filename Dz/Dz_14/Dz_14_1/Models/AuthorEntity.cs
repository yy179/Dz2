﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_14_1.Models
{
    public class AuthorEntity
    {
        public Guid Id { get; set; }
        public string Username { get; set; } = string.Empty;
        public List<ArticleEntity> Articles { get; set; } = [];
    }
}
