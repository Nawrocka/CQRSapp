using EduPlatform.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace EduPlatform.Domain.Entities
{
    public class Category : AuditableEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public List<Post> Posts { get; set; }
    }
}
