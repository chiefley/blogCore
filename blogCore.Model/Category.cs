using System;
using System.Collections.Generic;
using System.Text;

namespace blogCore.Model
{
    public class Category : BaseModel
    {
        public string Name { get; set; }
        public string Slug { get; set; }
        public virtual Category Parent { get; set; }
        public virtual ICollection<Category> Children { get; set; } = new List<Category>();
        public virtual ICollection<Article> Articles { get; set; } = new List<Article>();
    }
}
