using CoreBlogApp.Business.Abstract;
using CoreBlogApp.DataAccess.Abstract;
using CoreBlogApp.Entity.DbEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreBlogApp.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public int Delete(Category obj)
        {
            return _categoryDal.Delete(obj);
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetList();
        }

        public Category GetById(int id)
        {
            return _categoryDal.GetById(x => x.CategoryId == id);
        }

        public int Insert(Category obj)
        {
            return _categoryDal.Insert(obj);
        }

        public int Update(Category obj)
        {
            return _categoryDal.Update(obj);
        }
    }
}
