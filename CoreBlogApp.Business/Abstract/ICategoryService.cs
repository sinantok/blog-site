using CoreBlogApp.Entity.DbEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreBlogApp.Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();

        Category GetById(int id);

        int Insert(Category obj);

        int Update(Category obj);

        int Delete(Category obj);
    }
}
