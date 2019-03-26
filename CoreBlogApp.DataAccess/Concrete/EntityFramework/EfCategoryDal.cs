using CoreBlogApp.Core.DataAccess.EntityFramework;
using CoreBlogApp.DataAccess.Abstract;
using CoreBlogApp.Entity.DbEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreBlogApp.DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, DatabaseContext>, ICategoryDal
    {
    }
}
