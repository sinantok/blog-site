using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace CoreBlogApp.Core.Abstract
{
    public interface IRepository<T>
    {
        T GetById(Expression<Func<T, bool>> where);

        IQueryable<T> GetAll();

        int Insert(T obj);

        int Update(T obj);

        int Delete(T obj);

        int Save();
    }
}
