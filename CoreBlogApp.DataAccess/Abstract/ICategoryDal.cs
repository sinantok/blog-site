using CoreBlogApp.Core.DataAccess;
using CoreBlogApp.Entity.DbEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreBlogApp.DataAccess.Abstract
{
    public interface ICategoryDal : IEntityRepository<Category> //dataAccessLayer
    {
    }
}
