using CoreBlogApp.Entity.DbEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBlogApp.WebUI.Models
{
    public class IndexBlogModel
    {
        public List<Blog> IndexBlogs { get; set; }
        public List<Blog> SliderBlogs { get; set; }
    }
}
