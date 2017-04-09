using System;
using System.Collections.Generic;

namespace blogCore.Model
{
    public class Article : BaseModel
    {
        public enum ArticleVisibility
        {
            Draft = 0,
            Private = 1,
            Protected = 2,
            Public = 3
        }

        public string Name { get; set; }
        public string Slug { get; set; }
        public bool Published { get; set; }
        public ArticleVisibility Visibility { get; set; }
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public virtual ICollection<Tag> Tags { get; set; }
        public virtual ICollection<Category> Categories { get; set; }
    }
}
