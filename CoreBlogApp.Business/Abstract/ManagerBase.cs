using CoreBlogApp.Core.Abstract;
using CoreBlogApp.DataAccess.Concrete.EFCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace CoreBlogApp.Business.Abstract
{
    public abstract class ManagerBase<T> : IRepository<T> where T : class
    {
        private Repository<T> repository = new Repository<T>();

        public virtual int Delete(T obj)
        {
            return repository.Delete(obj);
        }

        public virtual IQueryable<T> GetAll()
        {
            return repository.GetAll();
        }

        public virtual T GetById(Expression<Func<T, bool>> where)
        {
            return repository.GetById(where);
        }

        public virtual int Insert(T obj)
        {
            return repository.Insert(obj);
        }

        public virtual int Save()
        {
            return repository.Save();
        }

        public virtual int Update(T obj)
        {
            return repository.Update(obj);
        }
    }

}
