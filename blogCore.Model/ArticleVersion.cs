using System;
using System.Collections.Generic;
using System.Text;

namespace blogCore.Model
{
    public class ArticleVersion : BaseModel
    {
        public string Content { get; set; }
        public virtual string Article { get; set; }
    }
}
