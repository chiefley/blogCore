using System;
using System.Collections.Generic;
using System.Text;

namespace blogCore.Model
{
    public class Tag : BaseModel
    {
        public string Name { get; set; }
        public string Slug { get; set; }
        public virtual ICollection<Article> Articles { get; set; }
    }
}
