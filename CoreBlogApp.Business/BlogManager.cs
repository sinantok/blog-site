using CoreBlogApp.Business.Abstract;
using CoreBlogApp.Entity.DbEntities;
using CoreBlogApp.Entity.ResultModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using CoreBlogApp.DataAccess.Concrete.EFCore;

namespace CoreBlogApp.Business
{
    public class BlogManager : ManagerBase<Blog>
    {
        public MessageResult<Blog> Listele(int id)
        {
            MessageResult<Blog> res = new MessageResult<Blog>();
            res.Result = GetById(x => x.BlogId == id);

            return res;
        }
    }
}
