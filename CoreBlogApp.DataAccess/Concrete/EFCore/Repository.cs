using CoreBlogApp.Core.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace CoreBlogApp.DataAccess.Concrete.EFCore
{
    public class Repository<T> : RepositoryBase, IRepository<T> where T : class
    {
        private DbSet<T> _objSet;
            
        public Repository()
        {
            _objSet = context.Set<T>();
        }

        public IQueryable<T> GetAll()
        {
            return _objSet.AsQueryable<T>();
        }
        
        public T GetById(Expression<Func<T, bool>> where)
        {
            return _objSet.FirstOrDefault(where);
        }

        public int Insert(T obj)
        {
            _objSet.Add(obj);
            return Save();
        }

        public int Update(T obj)
        {
            //context.Entry(obj).State = EntityState.Modified;
            return Save();
        }

        public int Delete(T obj)
        {
            _objSet.Remove(obj);
            return Save();
        }

        public int Save()
        {
            return context.SaveChanges();
        }
    }
}
